using System;

namespace Compiler
{
    public class ControlToken : Token
    {
        public ControlType ControlType { get; }

        internal ControlToken(string text) : base(text, TokenType.Control)
        {
            switch (text)
            {
                case "{":
                    ControlType = ControlType.OpenBlock;
                    break;
                case "}":
                    ControlType = ControlType.CloseBlock;
                    break;
                case "(":
                    ControlType = ControlType.OpenParentheses;
                    break;
                case ")":
                    ControlType = ControlType.CloseParentheses;
                    break;
                case ";":
                    ControlType = ControlType.SemiColon;
                    break;
                default:
                    throw new Exception("Invalid text for Control Token");
            }
        }

        public override string ToString()
        {
            return $"<{ControlType}>";
        }
    }
}