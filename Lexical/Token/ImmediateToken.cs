namespace Lexical.Token
{
    public class ImmediateToken : Token
    {
        public string Value { get; }

        public ImmediateToken(TokenType type, int line, int column, string value) : base(type, line, column)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"<{Line}-{Column} = {Type} - {Value}>";
        }
    }
}