namespace Compiler.Analyser
{
    public enum NonTerminalType : long
    {
        Begin = 0x1,
        Statement = 0x2,
        StatementAux = 0x4,
        DeclVariable = 0x8,
        Cirno = 0x10,
        Mokou = 0x20,
        Cheeen = 0x40,
        Marisa = 0x80,
        Stb = 0x1_00,
        Attribution = 0x2_00,
        DeclVariableAux = 0x4_00,
        BoolExpression = 0x8_00,
        CirnoAux = 0x10_00,
        CheeenAttribution = 0x20_00,
        CheeenExpression = 0x40_00,
        Expression = 0x80_00,
        RelationalExpression = 0x1_00_00,
        BoolExpressionAux = 0x2_00_00,
        Value = 0x4_00_00,
        ExpressionAux = 0x8_00_00,
        RelationalExpressionAux = 0x10_00_00,
    }
}