using System;

namespace Compiler
{
    public class ArithmeticToken : Token
    {
        public ArithmeticType ArithmeticType { get; }

        internal ArithmeticToken(string text) : base(text, TokenType.ArithmeticOperator)
        {
            switch (text)
            {
                case "+":
                    ArithmeticType = ArithmeticType.Plus;
                    break;
                case "-":
                    ArithmeticType = ArithmeticType.Substract;
                    break;
                case "%":
                    ArithmeticType = ArithmeticType.Remainder;
                    break;
                case "*":
                    ArithmeticType = ArithmeticType.Times;
                    break;
                case "/":
                    ArithmeticType = ArithmeticType.Division;
                    break;
                default:
                    throw new Exception("Invalid Arithmetic Token Text");
            }
        }

        public override string ToString()
        {
            return $"<{ArithmeticType}>";
        }
    }
}