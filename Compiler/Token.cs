using System.CodeDom;
using System.Text.RegularExpressions;

namespace Compilador
{
    public class Token
    {
        public string Text { get; }

        public Token(string text)
        {
            Text = text;
        }

        public static Token GetFrom(string content)
        {
            if (Regex.IsMatch(content, "^[_a-zA-Z][_a-zA-Z0-9]*$"))
            {
                // é um ID - tem que verificar se é palavra reservada
            }

            if (Regex.IsMatch(content, @"^-?(\d*\.\d+|\d+)$"))
            {
                // é um número - tem que ver se é decimal ou não
            }

            if (Regex.IsMatch(content, "^\"[^\n\"]*\"$"))
            {
                // é uma string
            }

            if (Regex.IsMatch(content, @"^(\+|\*|%|&|\||\#|\{|\}|\(|\)|;|==|<=|>=|!=|=|<|>|!|/|-)$"))
            {
                // é um operador ou caracter de controle tem que verificar
            }

            return null;
        }
    }
}