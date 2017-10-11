using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical.Token
{
    public class TokenStream : IDisposable
    {
        private readonly StreamReader _reader;
        private readonly StringBuilder _builder;
        public int Line { get; private set; }
        public int Column { get; private set; }

        public TokenStream(string file)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException($"Invalid path \"{file}\"");
            }

            _builder = new StringBuilder();
            _reader = new StreamReader(File.OpenRead(file));
            Line = 1;
            Column = 1;
        }

        public Token Read()
        {
            var state = 1;

            while (true)
            {
                var c = (char) _reader.Peek();
                switch (state)
                {
                    #region State 1
                    case 1:
                        if (TokenUtil.IsWhiteSpace(c))
                        {
                            break;
                        }

                        if (TokenUtil.IsInitOfId(c))
                        {
                            state = 2;
                            _builder.Append(c);
                            break;
                        }

                        if (TokenUtil.IsDigit(c))
                        {
                            state = 3;
                            _builder.Append(c);
                            break;
                        }

                        switch (c)
                        {
                            case '.':
                                _builder.Append(c);
                                state = 4;
                                break;
                            case '"':
                                state = 6;
                                break;
                            case '/':
                                _builder.Append(c);
                                state = 7;
                                break;
                        }

                        if (TokenUtil.IsCompositeOperator(c))
                        {
                            _builder.Append(c);
                            state = 9;
                            break;
                        }

                        if (!TokenUtil.IsSingleOperator(c))
                            throw new Exception($"Unknown character '{c}'. Line {Line}: Column {Column}");


                        break;
                    #endregion
                    
                    default:
                        break;
                }
            }

            return null;
        }

        public void Dispose()
        {
            _reader?.Dispose();
        }
    }
}
