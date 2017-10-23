using System;

namespace Compiler.Token
{
    public class Token
    {
        public TokenType Type { get; protected set; }
        public int Line { get; }
        public int Column { get; }

        public Token(TokenType type, int line, int column)
        {
            Type = type;
            Line = line;
            Column = column;
        }

        public override string ToString()
        {
            return $"<{Line}-{Column} = {Type}>";
        }

        public static Token GetReservedOrId(string content, int line, int column)
        {
            switch (content)
            {
                case "JAOOOO":
                    return new Token(TokenType.Jaoooo, line, column);
                case "nani":
                    return new Token(TokenType.Nani, line, column);
                case "honk":
                    return new Token(TokenType.Honk, line, column);
                case "pedal":
                    return new Token(TokenType.Pedal, line, column);
                case "th1":
                    return new Token(TokenType.Th1, line, column);
                case "th2":
                    return new Token(TokenType.Th2, line, column);
                case "th4":
                    return new Token(TokenType.Th4, line, column);
                case "th8":
                    return new Token(TokenType.Th8, line, column);
                case "kk4":
                    return new Token(TokenType.Kk4, line, column);
                case "kk8":
                    return new Token(TokenType.Kk8, line, column);
                case "cirno":
                    return new Token(TokenType.Cirno, line, column);
                case "mokou":
                    return new Token(TokenType.Mokou, line, column);
                case "baka":
                    return new Token(TokenType.Baka, line, column);
                case "cheeen":
                    return new Token(TokenType.Cheeen, line, column);
                case "marisa":
                    return new Token(TokenType.Marisa, line, column);
                case "stb":
                    return new Token(TokenType.Stb, line, column);
                case "true":
                    return new Token(TokenType.True, line, column);
                case "false":
                    return new Token(TokenType.False, line, column);
                default:
                    return new IdentifierToken(TokenType.Identifier, line, column, content);
            }
        }

        public static Token GetOperator(string token, int line, int column)
        {
            switch (token)
            {
                #region Relational Operators

                case "<":
                    return new Token(TokenType.Lower, line, column);
                case "<=":
                    return new Token(TokenType.LowerEquals, line, column);
                case ">":
                    return new Token(TokenType.Greater, line, column);
                case ">=":
                    return new Token(TokenType.GreaterEquals, line, column);
                case "==":
                    return new Token(TokenType.Equals, line, column);
                case "!=":
                    return new Token(TokenType.Different, line, column);

                #endregion

                #region Arithmetic Operators

                case "+":
                    return new Token(TokenType.Sum, line, column);
                case "-":
                    return new Token(TokenType.Substract, line, column);
                case "*":
                    return new Token(TokenType.Multiply, line, column);
                case "/":
                    return new Token(TokenType.Division, line, column);
                case "%":
                    return new Token(TokenType.Modulus, line, column);

                #endregion

                #region Binary Operators

                case "!":
                    return new Token(TokenType.Not, line, column);
                case "&":
                    return new Token(TokenType.And, line, column);
                case "|":
                    return new Token(TokenType.Or, line, column);
                case "#":
                    return new Token(TokenType.Xor, line, column);

                #endregion

                #region Control Token

                case ";":
                    return new Token(TokenType.Semicolon, line, column);
                case "(":
                    return new Token(TokenType.OpenParenthesis, line, column);
                case ")":
                    return new Token(TokenType.CloseParenthesis, line, column);
                case "{":
                    return new Token(TokenType.OpenBracket, line, column);
                case "}":
                    return new Token(TokenType.CloseBracket, line, column);

                #endregion

                #region Assignment

                case "=":
                    return new Token(TokenType.Assignment, line, column);

                #endregion

                default:
                    throw new ArgumentException($"Token \"{token}\" is not an operator");
            }
        }
    }
}