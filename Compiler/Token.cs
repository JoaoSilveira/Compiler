using System;
using System.CodeDom;
using System.Linq;
using System.Text.RegularExpressions;
using Compiler;

namespace Compiler
{
    public class Token
    {
        public string Text { get; }
        public TokenType Type { get; }

        protected Token(string text, TokenType type)
        {
            Text = text;
            Type = type;
        }

        public static Token GetFrom(string content)
        {
            if (Regex.IsMatch(content, "^[_a-zA-Z][_a-zA-Z0-9]*$"))
            {
                if (Enum.TryParse<TokenType>(content, out var result) && (result & TokenType.Reserved) != 0)
                {
                    return new Token(content, result);
                }

                return new Token(content, TokenType.Identifier);
            }

            return null;
            //if (Regex.IsMatch(content, "^[_a-zA-Z][_a-zA-Z0-9]*$"))
            //{
            //    return ReservedToken.IsReservedWord(content)
            //        ? new ReservedToken(content)
            //        : new Token(content, TokenType.Identifier);
            //}

            //if (Regex.IsMatch(content, @"^-?(?:\d*\.\d+|\d+)$"))
            //{
            //    return new ImmediateToken(content);
            //}

            //if (Regex.IsMatch(content, @"^(?:\+|\*|%|-|/)$"))
            //{
            //    return new ArithmeticToken(content);
            //}

            //if (Regex.IsMatch(content, @"^(?:\{|\}|\(|\)|;)$"))
            //{
            //    return new ControlToken(content);
            //}

            //if (Regex.IsMatch(content, @"^(?:&|\||\#|!)$"))
            //{
            //    return new LogicalToken(content);
            //}

            //if (Regex.IsMatch(content, @"^(?:==|<=|>=|!=|<|>)$"))
            //{
            //    // é um operador ou caracter de controle tem que verificar
            //    return new RelationalToken(content);
            //}

            //return Regex.IsMatch(content, "^=$") ? new Token(content, TokenType.Assignment) : new Token(content, TokenType.Text);
        }

        public override string ToString()
        {
            return $"<{Type} - '{Text}'>";
        }
    }
}