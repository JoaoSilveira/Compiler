using System.Text.RegularExpressions;

namespace Compiler
{
    public class ImmediateToken : Token
    {
        public ImmediateType ImmediateType { get; }

        internal ImmediateToken(string text) : base(text, TokenType.Immediate)
        {
            ImmediateType = Regex.IsMatch(text, "\\.") ? ImmediateType.Float : ImmediateType.Integer;
        }

        public override string ToString()
        {
            return $"<{ImmediateType} - {Text}>";
        }
    }
}