using System;
using Compiler.Token;

namespace Compiler.Analyser
{
    public struct StackObject
    {
        #region Queue Objects

        public static readonly StackObject End = new StackObject((long)TokenType.EndString, true);
        public static readonly StackObject Jaoooo = new StackObject((long)TokenType.Jaoooo, true);
        public static readonly StackObject Nani = new StackObject((long)TokenType.Nani, true);
        public static readonly StackObject Honk = new StackObject((long)TokenType.Honk, true);
        public static readonly StackObject Pedal = new StackObject((long)TokenType.Pedal, true);
        public static readonly StackObject Semicolon = new StackObject((long)TokenType.Semicolon, true);
        public static readonly StackObject Identifier = new StackObject((long)TokenType.Identifier, true);
        public static readonly StackObject OpenParenthesis = new StackObject((long)TokenType.OpenParenthesis, true);
        public static readonly StackObject CloseParenthesis = new StackObject((long)TokenType.CloseParenthesis, true);
        public static readonly StackObject Cirno = new StackObject((long)TokenType.Cirno, true);
        public static readonly StackObject Mokou = new StackObject((long)TokenType.Mokou, true);
        public static readonly StackObject Baka = new StackObject((long)TokenType.Baka, true);
        public static readonly StackObject Cheeen = new StackObject((long)TokenType.Cheeen, true);
        public static readonly StackObject Marisa = new StackObject((long)TokenType.Marisa, true);
        public static readonly StackObject Stb = new StackObject((long)TokenType.Stb, true);
        public static readonly StackObject Immediate = new StackObject((long)TokenType.Immediate, true);
        public static readonly StackObject OpenBracket = new StackObject((long)TokenType.OpenBracket, true);
        public static readonly StackObject CloseBracket = new StackObject((long)TokenType.CloseBracket, true);
        public static readonly StackObject Text = new StackObject((long)TokenType.Text, true);
        public static readonly StackObject Assignment = new StackObject((long)TokenType.Assignment, true);
        public static readonly StackObject Not = new StackObject((long)TokenType.Not, true);
        public static readonly StackObject And = new StackObject((long)TokenType.And, true);
        public static readonly StackObject Or = new StackObject((long)TokenType.Or, true);
        public static readonly StackObject Xor = new StackObject((long)TokenType.Xor, true);
        public static readonly StackObject Sum = new StackObject((long)TokenType.Sum, true);
        public static readonly StackObject Substract = new StackObject((long)TokenType.Substract, true);
        public static readonly StackObject Multiply = new StackObject((long)TokenType.Multiply, true);
        public static readonly StackObject Division = new StackObject((long)TokenType.Division, true);
        public static readonly StackObject Modulus = new StackObject((long)TokenType.Modulus, true);
        public static readonly StackObject True = new StackObject((long)TokenType.True, true);
        public static readonly StackObject False = new StackObject((long)TokenType.False, true);
        public static readonly StackObject Greater = new StackObject((long)TokenType.Greater, true);
        public static readonly StackObject GreaterEquals = new StackObject((long)TokenType.GreaterEquals, true);
        public static readonly StackObject Lower = new StackObject((long)TokenType.Lower, true);
        public static readonly StackObject LowerEquals = new StackObject((long)TokenType.LowerEquals, true);
        public static readonly StackObject EqualsTerminal = new StackObject((long)TokenType.Equals, true);
        public static readonly StackObject Different = new StackObject((long)TokenType.Different, true);
        public static readonly StackObject VarType = new StackObject((long)TokenType.VarType, true);
        public static readonly StackObject BeginNT = new StackObject((long)NonTerminalType.Begin, false);
        public static readonly StackObject StatementNT = new StackObject((long)NonTerminalType.Statement, false);
        public static readonly StackObject StatementAuxNT = new StackObject((long)NonTerminalType.StatementAux, false);
        public static readonly StackObject DeclVariableNT = new StackObject((long)NonTerminalType.DeclVariable, false);
        public static readonly StackObject CirnoNT = new StackObject((long)NonTerminalType.Cirno, false);
        public static readonly StackObject MokouNT = new StackObject((long)NonTerminalType.Mokou, false);
        public static readonly StackObject CheeenNT = new StackObject((long)NonTerminalType.Cheeen, false);
        public static readonly StackObject MarisaNT = new StackObject((long)NonTerminalType.Marisa, false);
        public static readonly StackObject StbNT = new StackObject((long)NonTerminalType.Stb, false);
        public static readonly StackObject AttributionNT = new StackObject((long)NonTerminalType.Attribution, false);
        public static readonly StackObject DeclVariableAuxNT = new StackObject((long)NonTerminalType.DeclVariableAux, false);
        public static readonly StackObject BoolExpressionNT = new StackObject((long)NonTerminalType.BoolExpression, false);
        public static readonly StackObject CirnoAuxNT = new StackObject((long)NonTerminalType.CirnoAux, false);
        public static readonly StackObject CheeenAttributionNT = new StackObject((long)NonTerminalType.CheeenAttribution, false);
        public static readonly StackObject CheeenExpressionNT = new StackObject((long)NonTerminalType.CheeenExpression, false);
        public static readonly StackObject ExpressionNT = new StackObject((long)NonTerminalType.Expression, false);
        public static readonly StackObject RelationalExpressionNT = new StackObject((long)NonTerminalType.RelationalExpression, false);
        public static readonly StackObject BoolExpressionAuxNT = new StackObject((long)NonTerminalType.BoolExpressionAux, false);
        public static readonly StackObject ValueNT = new StackObject((long)NonTerminalType.Value, false);
        public static readonly StackObject ExpressionAuxNT = new StackObject((long)NonTerminalType.ExpressionAux, false);
        public static readonly StackObject RelationalExpressionAuxNT = new StackObject((long)NonTerminalType.RelationalExpressionAux, false);

        #endregion

        public long Data { get; }

        public bool IsTerminal { get; }

        public int Line { get; set; }

        public int Column { get; set; }

        public StackObject(long data, bool isTerminal)
        {
            Data = data;
            IsTerminal = isTerminal;
            Line = 0;
            Column = 0;
        }

        public StackObject(long data, bool isTerminal, int line, int column)
        {
            Data = data;
            IsTerminal = isTerminal;
            Line = line;
            Column = column;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var other = (StackObject)obj;

            return Data == other.Data && IsTerminal == other.IsTerminal;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Data.GetHashCode() * 397) ^ IsTerminal.GetHashCode();
            }
        }

        public override string ToString()
        {
            return IsTerminal ? $"[{(TokenType)Enum.ToObject(typeof(TokenType), Data)}]"
                : $"<{(NonTerminalType)Enum.ToObject(typeof(NonTerminalType), Data)}>";
        }
    }
}