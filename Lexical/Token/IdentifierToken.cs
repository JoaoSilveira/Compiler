using System;

namespace Lexical.Token
{
    public class IdentifierToken : Token
    {
        public string Identifier { get; }

        public IdentifierToken(TokenType type, int line, int column, string identifier) : base(type, line, column)
        {
            Identifier = identifier;
        }

        public void ResolveType(TokenType type)
        {
            if ((Type & TokenType.VarType) != 0)
                throw new Exception("Can't change an Identifier's type");

            Type |= TokenType.VarType;
        }

        public override string ToString()
        {
            return $"<{Line}-{Column} = {Type} - {Identifier}>";
        }
    }
}