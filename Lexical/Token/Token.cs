using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical.Token
{
    public class Token
    {
        public TokenType Type { get; }
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
            return $"<{Type}>";
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
                    return new Token(TokenType.SemiColon, line, column);
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