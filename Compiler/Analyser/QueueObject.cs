using Compiler.Token;

namespace Compiler.Analyser
{
    public struct QueueObject
    {
        #region Queue Objects

        public static readonly QueueObject End = new QueueObject((long) TokenType.EndString, true);
        public static readonly QueueObject Jaoooo = new QueueObject((long) TokenType.Jaoooo, true);
        public static readonly QueueObject Nani = new QueueObject((long) TokenType.Nani, true);
        public static readonly QueueObject Honk = new QueueObject((long) TokenType.Honk, true);
        public static readonly QueueObject Pedal = new QueueObject((long) TokenType.Pedal, true);
        public static readonly QueueObject Semicolon = new QueueObject((long) TokenType.Semicolon, true);
        public static readonly QueueObject Identifier = new QueueObject((long) TokenType.Identifier, true);
        public static readonly QueueObject OpenParenthesis = new QueueObject((long) TokenType.OpenParenthesis, true);
        public static readonly QueueObject CloseParenthesis = new QueueObject((long) TokenType.CloseParenthesis, true);
        public static readonly QueueObject Cirno = new QueueObject((long) TokenType.Cirno, true);
        public static readonly QueueObject Mokou = new QueueObject((long) TokenType.Mokou, true);
        public static readonly QueueObject Baka = new QueueObject((long) TokenType.Baka, true);
        public static readonly QueueObject Cheeen = new QueueObject((long) TokenType.Cheeen, true);
        public static readonly QueueObject Marisa = new QueueObject((long) TokenType.Marisa, true);
        public static readonly QueueObject Stb = new QueueObject((long) TokenType.Stb, true);
        public static readonly QueueObject Immediate = new QueueObject((long) TokenType.Immediate, true);
        public static readonly QueueObject OpenBracket = new QueueObject((long) TokenType.OpenBracket, true);
        public static readonly QueueObject CloseBracket = new QueueObject((long) TokenType.CloseBracket, true);
        public static readonly QueueObject Text = new QueueObject((long) TokenType.Text, true);
        public static readonly QueueObject Assignment = new QueueObject((long) TokenType.Assignment, true);
        public static readonly QueueObject Not = new QueueObject((long) TokenType.Not, true);
        public static readonly QueueObject And = new QueueObject((long) TokenType.And, true);
        public static readonly QueueObject Or = new QueueObject((long) TokenType.Or, true);
        public static readonly QueueObject Xor = new QueueObject((long) TokenType.Xor, true);
        public static readonly QueueObject Sum = new QueueObject((long) TokenType.Sum, true);
        public static readonly QueueObject Substract = new QueueObject((long) TokenType.Substract, true);
        public static readonly QueueObject Multiply = new QueueObject((long) TokenType.Multiply, true);
        public static readonly QueueObject Division = new QueueObject((long) TokenType.Division, true);
        public static readonly QueueObject Modulus = new QueueObject((long) TokenType.Modulus, true);
        public static readonly QueueObject True = new QueueObject((long) TokenType.True, true);
        public static readonly QueueObject False = new QueueObject((long) TokenType.False, true);
        public static readonly QueueObject Greater = new QueueObject((long) TokenType.Greater, true);
        public static readonly QueueObject GreaterEquals = new QueueObject((long) TokenType.GreaterEquals, true);
        public static readonly QueueObject Lower = new QueueObject((long) TokenType.Lower, true);
        public static readonly QueueObject LowerEquals = new QueueObject((long) TokenType.LowerEquals, true);
        public static readonly QueueObject EqualsTerminal = new QueueObject((long) TokenType.Equals, true);
        public static readonly QueueObject Different = new QueueObject((long) TokenType.Different, true);
        public static readonly QueueObject VarType = new QueueObject((long) TokenType.VarType, true);
        public static readonly QueueObject BeginNT = new QueueObject((long) NonTerminalType.Begin, false);
        public static readonly QueueObject StatementNT = new QueueObject((long) NonTerminalType.Statement, false);
        public static readonly QueueObject StatementAuxNT = new QueueObject((long) NonTerminalType.StatementAux, false);
        public static readonly QueueObject DeclVariableNT = new QueueObject((long) NonTerminalType.DeclVariable, false);
        public static readonly QueueObject CirnoNT = new QueueObject((long) NonTerminalType.Cirno, false);
        public static readonly QueueObject MokouNT = new QueueObject((long) NonTerminalType.Mokou, false);
        public static readonly QueueObject CheeenNT = new QueueObject((long) NonTerminalType.Cheeen, false);
        public static readonly QueueObject MarisaNT = new QueueObject((long) NonTerminalType.Marisa, false);
        public static readonly QueueObject StbNT = new QueueObject((long) NonTerminalType.Stb, false);
        public static readonly QueueObject AttributionNT = new QueueObject((long) NonTerminalType.Attribution, false);
        public static readonly QueueObject DeclVariableAuxNT = new QueueObject((long) NonTerminalType.DeclVariableAux, false);
        public static readonly QueueObject BoolExpressionNT = new QueueObject((long) NonTerminalType.BoolExpression, false);
        public static readonly QueueObject CirnoAuxNT = new QueueObject((long) NonTerminalType.CirnoAux, false);
        public static readonly QueueObject CheeenAttributionNT = new QueueObject((long) NonTerminalType.CheeenAttribution, false);
        public static readonly QueueObject CheeenExpressionNT = new QueueObject((long) NonTerminalType.CheeenExpression, false);
        public static readonly QueueObject ExpressionNT = new QueueObject((long) NonTerminalType.Expression, false);
        public static readonly QueueObject RelationalExpressionNT = new QueueObject((long) NonTerminalType.RelationalExpression, false);
        public static readonly QueueObject BoolExpressionAuxNT = new QueueObject((long) NonTerminalType.BoolExpressionAux, false);
        public static readonly QueueObject ValueNT = new QueueObject((long) NonTerminalType.Value, false);
        public static readonly QueueObject ExpressionAuxNT = new QueueObject((long) NonTerminalType.ExpressionAux, false);
        public static readonly QueueObject RelationalExpressionAuxNT = new QueueObject((long) NonTerminalType.RelationalExpressionAux, false);

        #endregion

        public long Data { get; }

        public bool IsTerminal { get; }

        public QueueObject(long data, bool isTerminal)
        {
            Data = data;
            IsTerminal = isTerminal;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var other = (QueueObject)obj;

            return Data == other.Data && IsTerminal == other.IsTerminal;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Data.GetHashCode() * 397) ^ IsTerminal.GetHashCode();
            }
        }
    }
}