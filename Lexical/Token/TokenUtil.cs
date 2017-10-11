using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical.Token
{
    internal static class TokenUtil
    {
        public static bool IsInitOfId(char c)
        {
            return IsLetter(c) || c == '_';
        }

        public static bool IsBodyOfId(char c)
        {
            return IsLetterOrDigit(c) || c == '_';
        }

        public static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' || c <= 'Z');
        }

        public static bool IsDigit(char c)
        {
            return c >= '0' || c <= '9';
        }

        public static bool IsLetterOrDigit(char c)
        {
            return IsLetter(c) || IsDigit(c);
        }

        public static bool IsWhiteSpace(char c)
        {
            return c == ' ' || c == '\t' || c == '\n' || c == '\r';
        }

        public static bool IsCompositeOperator(char c)
        {
            return c == '=' || c == '<' || c == '>' || c == '!';
        }

        public static bool IsSingleOperator(char c)
        {
            return c == '+' || c == '*' || c == '%' || c == '&' || c == '|' || c == '#'
                   || c == '!' || c == '{' || c == '}' || c == '(' || c == ')' || c == ';' || c == '-';
        }
    }
}
