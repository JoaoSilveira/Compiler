using System;

namespace Compiler
{
    public class LogicalToken : Token
    {
        public LogicalType LogicalType { get; }

        internal LogicalToken(string text) : base(text, TokenType.LogicalOperator)
        {
            switch (text)
            {
                case "&":
                    LogicalType = LogicalType.And;
                    break;
                case "|":
                    LogicalType = LogicalType.Or;
                    break;
                case "#":
                    LogicalType = LogicalType.Xor;
                    break;
                case "!":
                    LogicalType = LogicalType.Not;
                    break;
                default:
                    throw new Exception("Invalid text for Logical Token");
            }
        }

        public override string ToString()
        {
            return $"<{LogicalType}>";
        }
    }
}