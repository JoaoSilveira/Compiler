using System;

namespace Compiler
{
    public class RelationalToken : Token
    {
        public RelationalType RelationalType { get; }

        internal RelationalToken(string text) : base(text, TokenType.RelationalOperator)
        {
            switch (text)
            {
                case "==":
                    RelationalType = RelationalType.Equals;
                    break;
                case "!=":
                    RelationalType = RelationalType.NotEquals;
                    break;
                case ">=":
                    RelationalType = RelationalType.GreaterEquals;
                    break;
                case ">":
                    RelationalType = RelationalType.Greater;
                    break;
                case "<=":
                    RelationalType = RelationalType.LowerEquals;
                    break;
                case "<":
                    RelationalType = RelationalType.Lower;
                    break;
                default:
                    throw new Exception("Invalid text for relational token");
            }
        }

        public override string ToString()
        {
            return $"<{RelationalType}>";
        }
    }
}