using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compilador
{
    class LexicalAnalyzer
    {
        private StreamReader Reader { get; }

        private StringBuilder Builder { get; }

        private char GetChar => (char)Reader.Peek();

        private Func<bool> State { get; set; }

        public LexicalAnalyzer(StreamReader reader)
        {
            Reader = reader;
            Builder = new StringBuilder();
            State = State1;
        }

        public IEnumerable<Token> GetTokens()
        {
            while (!Reader.EndOfStream)
            {
                if (State())
                    yield return GetToken();

                Next();
            }
        }

        private bool State1()
        {
            var c = GetChar;
            Push(c);

            if (IsInitOfId(c)) // leu um caracter
            {
                State = State2;

                return false;
            }

            if (c == '-')
            {
                State = State3;

                return false;
            }

            if (char.IsDigit(c))
            {
                State = State4;

                return false;
            }

            if (c == '.')
            {
                State = State5;

                return false;
            }

            throw new Exception("Caracter não reconhecido");
        }

        private bool State2()
        {
            var c = GetChar;

            if (!IsBodyOfId(c))
            {
                return true;
            }

            Push(c);
            return false;
        }

        private bool State3()
        {
            var c = GetChar;

            if (char.IsNumber(c))
            {
                Push(c);
                State = State4;
                return false;
            }

            if (c != '.')
                return true;

            Push(c);
            State = State5;
            return false;
        }

        private bool State4()
        {
            var c = GetChar;

            if (char.IsNumber(c))
            {
                Push(c);
                return false;
            }

            if (c != '.')
                return true;

            Push(c);
            State = State5;
            return false;
        }

        private bool State5()
        {
            var c = GetChar;

            if (!char.IsDigit(c))
                throw new Exception("Espera-se pelo menos um dígito após o ponto");

            Push(c);
            State = State6;
            return false;
        }

        private bool State6()
        {
            var c = GetChar;

            if (!char.IsNumber(c))
                return true;

            Push(c);
            return false;
        }

        private void Next()
        {
            Reader.BaseStream.Position += 1;
        }

        private void Back()
        {
            Reader.BaseStream.Position -= 1;
        }

        private void Push(char c)
        {
            Builder.Append(c);
        }

        private Token GetToken()
        {
            var tk = new Token(Builder.ToString());
            Builder.Clear();
            Back();

            return tk;
        }

        public static bool IsInitOfId(char c)
        {
            return char.IsLetter(c) || c == '_';
        }

        public static bool IsBodyOfId(char c)
        {
            return char.IsLetterOrDigit(c) || c == '_';
        }
    }
}
