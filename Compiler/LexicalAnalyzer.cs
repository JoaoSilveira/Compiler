using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class LexicalAnalyzer
    {
        private CustomStream Reader { get; }

        private StringBuilder Builder { get; }

        private char GetChar => (char)Reader.Peek();

        private Func<bool> State { get; set; }

        public LexicalAnalyzer(CustomStream reader)
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
                {
                    yield return GetToken();
                    State = State1;
                }

                Next();
            }

            if (Builder.Length > 0)
            {
                yield return GetToken();
            }
        }

        private bool State1()
        {
            var c = GetChar;

            if (IsInitOfId(c))
            {
                Push(c);
                State = State2;

                return false;
            }

            if (char.IsDigit(c))
            {
                Push(c);
                State = State3;

                return false;
            }

            switch (c)
            {
                case '.':
                    Push(c);
                    State = State4;

                    return false;
                case '"':
                    State = State6;

                    return false;
                case '/':
                    Push(c);
                    State = State7;

                    return false;
            }

            if (IsCompositeOp(c))
            {
                Push(c);
                State = State9;

                return false;
            }

            if (IsWhiteSpace(c))
            {
                return false;
            }

            if (!IsSingleOp(c))
                throw new Exception($"Unknown character '{c}'. Line {Reader.Line}: Column {Reader.Column}");

            Push(c);
            return true;
        }

        private bool State2()
        {
            var c = GetChar;

            if (!IsBodyOfId(c))
            {
                Back();
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
                return false;
            }

            if (c != '.')
            {
                Back();
                return true;
            }

            Push(c);
            State = State4;
            return false;
        }

        private bool State4()
        {
            var c = GetChar;

            if (!char.IsDigit(c))
                throw new Exception($"Expected a digit after dot. Line {Reader.Line}: Column {Reader.Column}");

            Push(c);
            State = State5;
            return false;
        }

        private bool State5()
        {
            var c = GetChar;

            if (!char.IsNumber(c))
            {
                Back();
                return true;
            }

            Push(c);
            return false;
        }

        private bool State6()
        {
            var c = GetChar;

            switch (c)
            {
                case '"':
                    return true;
                case '\n':
                    throw new Exception($"Expected end of string before new line. Line {Reader.Line}: Column {Reader.Column}");
                default:
                    Push(c);
                    return false;
            }
        }

        private bool State7()
        {
            var c = GetChar;

            if (c != '/')
            {
                Back();
                return true;
            }

            Push(c);

            State = State8;
            return false;
        }

        private bool State8()
        {
            var c = GetChar;

            if (c == '\n')
            {
                Clear();
                State = State1;
                return false;
            }

            Push(c);
            return false;
        }

        private bool State9()
        {
            var c = GetChar;

            if (c == '=')
            {
                Push(c);

                return true;
            }

            Back();

            return true;
        }

        private void Next()
        {
            Reader.Next();
        }

        private void Back()
        {
            Reader.Back();
        }

        private void Push(char c)
        {
            Builder.Append(c);
        }

        private void Clear()
        {
            Builder.Clear();
        }

        private Token GetToken()
        {
            var tk = Token.GetFrom(Builder.ToString());
            Builder.Clear();

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

        public static bool IsCompositeOp(char c)
        {
            return c == '=' || c == '<' || c == '>' || c == '!';
        }

        public static bool IsSingleOp(char c)
        {
            return c == '+' || c == '*' || c == '%' || c == '&' || c == '|' || c == '#'
                   || c == '!' || c == '{' || c == '}' || c == '(' || c == ')' || c == ';' || c == '-';
        }

        public static bool IsWhiteSpace(char c)
        {
            return c == ' ' || c == '\t' || c == '\n' || c == '\r';
        }
    }
}
