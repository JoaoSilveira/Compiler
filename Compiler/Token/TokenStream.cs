using System;
using System.IO;
using System.Text;

namespace Compiler.Token
{
    public class TokenStream : IDisposable
    {
        private readonly StreamReader _reader;
        private readonly StringBuilder _builder;
        public int Line { get; private set; }
        public int Column { get; private set; }
        public bool EndOfStream => _reader != null && _reader.EndOfStream;
        private Token _peekObj;

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

        public Token LastRead()
        {
            return _peekObj;
        }

        public Token Read()
        {
            var state = 1;

            _builder.Clear();

            while (true)
            {
                var c = (char)_reader.Peek();

                switch (state)
                {
                    #region State 1
                    case 1:
                        if (TokenUtil.IsWhiteSpace(c))
                        {
                            Column++;
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

                        if (c == '.')
                        {
                            _builder.Append(c);
                            state = 4;
                            break;
                        }

                        if (c == '"')
                        {
                            state = 6;
                            break;
                        }

                        if (c == '/')
                        {
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

                        if (c == char.MaxValue)
                            return new Token(TokenType.EndString, Line, Column);

                        if (!TokenUtil.IsSingleOperator(c))
                            throw new Exception($"Unknown character '{c}'. Line {Line}: Column {Column}");

                        _builder.Append(c);
                        _reader.Read();
                        _peekObj = GetOperatorToken();
                        return _peekObj;
                    #endregion

                    #region State 2

                    case 2:
                        if (!TokenUtil.IsBodyOfId(c))
                        {
                            _peekObj = GetToken(TokenType.Identifier);
                            return _peekObj;
                        }

                        _builder.Append(c);
                        break;

                    #endregion

                    #region State 3

                    case 3:
                        if (char.IsNumber(c))
                        {
                            _builder.Append(c);
                            break;
                        }

                        if (c != '.')
                        {
                            _peekObj = GetToken(TokenType.Immediate | TokenType.Th8);
                            return _peekObj;
                        }

                        _builder.Append(c);
                        state = 4;
                        break;

                    #endregion

                    #region State 4

                    case 4:
                        if (!char.IsDigit(c))
                            throw new Exception($"Expected a digit after dot. Line {Line}: Column {Column}");

                        _builder.Append(c);
                        state = 5;
                        break;

                    #endregion

                    #region State 5

                    case 5:
                        if (!char.IsNumber(c))
                        {
                            _peekObj = GetToken(TokenType.Immediate | TokenType.Kk8);
                            return _peekObj;
                        }

                        _builder.Append(c);
                        break;

                    #endregion

                    #region State 6

                    case 6:
                        switch (c)
                        {
                            case '\\':
                                _reader.Read();

                                if (!GetEscapeChar((char)_reader.Peek(), out c))
                                {
                                    _builder.Append('\\');
                                }

                                _builder.Append(c);
                                break;
                            case '"':
                                _reader.Read();
                                _peekObj = GetToken(TokenType.Text);
                                return _peekObj;
                            case '\n':
                                throw new Exception($"Expected end of string before new line. Line {Line}: Column {Column}");
                            default:
                                _builder.Append(c);
                                break;
                        }
                        break;

                    #endregion

                    #region State 7

                    case 7:
                        if (c != '/')
                        {
                            _peekObj = GetOperatorToken();
                            return _peekObj;
                        }

                        _builder.Append(c);

                        state = 8;
                        break;

                    #endregion

                    #region State 8

                    case 8:
                        if (c == '\n')
                        {
                            _builder.Clear();
                            state = 1;
                        }
                        break;

                    #endregion

                    #region State 9

                    case 9:
                        if (c == '=')
                        {
                            _reader.Read();
                            _builder.Append(c);
                        }

                        _peekObj = GetOperatorToken();
                        return _peekObj;

                    #endregion

                    default:
                        throw new Exception("Something went Wrong with the compiler");
                }

                if (EndOfStream)
                    return new Token(TokenType.EndString, Line, Column);

                if (_reader.Read() != '\n') continue;

                Line++;
                Column = 1;
            }
        }

        private Token GetOperatorToken()
        {
            return GetGeneric(0, Token.GetOperator);
        }

        private Token GetToken(TokenType type)
        {
            Token token;
            if (type == TokenType.Identifier)
            {
                token = GetGeneric(0, Token.GetReservedOrId);
            }
            else if ((type & TokenType.Immediate) != 0)
            {
                var content = _builder.ToString();
                token = new ImmediateToken(type, Line, Column, content);
                Column += content.Length;
            }
            else
            {
                token = GetGeneric(type);
            }

            return token;
        }

        private Token GetGeneric(TokenType type, Func<string, int, int, Token> func = null)
        {
            var content = _builder.ToString();

            var token = func != null ?
                func(content, Line, Column) :
                new Token(type, Line, Column);

            Column += content.Length;

            return token;
        }

        public void Dispose()
        {
            _reader?.Dispose();
        }

        private static bool GetEscapeChar(char escape, out char c)
        {
            switch (escape)
            {
                case 't':
                    c = '\t';
                    return true;
                case 'n':
                    c = '\n';
                    return true;
                case 'r':
                    c = '\r';
                    return true;
                case '"':
                    c = '"';
                    return true;
                default:
                    c = escape;
                    return false;
            }
        }
    }
}
