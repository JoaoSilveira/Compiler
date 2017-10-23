using System.Collections.Generic;
using Compiler.Token;

namespace Compiler.Analyser
{
    public static class States
    {
        public static readonly Dictionary<StackObject, IAction>[] StateArray =
        {
            #region State 0

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Jaoooo, new StackAction(StackObject.Jaoooo, 2)},
                {StackObject.BeginNT, new TransitionAction(1) }
            },

            #endregion

            #region State 1

            new Dictionary<StackObject, IAction>
            {
                {StackObject.End,  new AcceptAction()}
            },

            #endregion

            #region State 2

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(3) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 3

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new StackAction(StackObject.Nani, 21)}
            },

            #endregion

            #region State 4

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(22) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 5

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.DeclVariableNT)},
            },

            #endregion

            #region State 6

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CirnoNT)},
            },

            #endregion

            #region State 7

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MokouNT)},
            },

            #endregion

            #region State 8

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.CheeenNT)},
            },

            #endregion

            #region State 9

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.MarisaNT)},
            },

            #endregion

            #region State 10

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.StbNT)},
            },

            #endregion

            #region State 11

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 23)}
            },

            #endregion

            #region State 12

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 24)}
            },

            #endregion

            #region State 13

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 25)}
            },

            #endregion

            #region State 14

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 26)}
            },

            #endregion

            #region State 15

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 27)}
            },

            #endregion

            #region State 16

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 28)}
            },

            #endregion

            #region State 17

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 29)}
            },

            #endregion

            #region State 18

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 30)}
            },

            #endregion

            #region State 19

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 31)}
            },

            #endregion

            #region State 20

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Assignment,  new StackAction(StackObject.Assignment, 32)}
            },

            #endregion

            #region State 21

            new Dictionary<StackObject, IAction>
            {
                {StackObject.End,  new ReduceAction(StackObject.BeginNT, StackObject.Jaoooo, StackObject.StatementNT, StackObject.Nani)}
            },

            #endregion

            #region State 22

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementNT, StackObject.StatementAuxNT, StackObject.StatementNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementNT, StackObject.StatementAuxNT, StackObject.StatementNT)}
            },

            #endregion

            #region State 23

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.AttributionNT, StackObject.Semicolon)},
            },

            #endregion

            #region State 24

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Honk, StackObject.Semicolon)},
            },

            #endregion

            #region State 25

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StatementAuxNT, StackObject.Pedal, StackObject.Semicolon)},
            },

            #endregion

            #region State 26

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.DeclVariableAuxNT)},
                {StackObject.Assignment,  new StackAction(StackObject.Assignment, 34)},
                {StackObject.DeclVariableAuxNT,  new TransitionAction(33)}
            },

            #endregion

            #region State 27

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(35)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 28

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(44)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 29

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.CheeenAttributionNT)},
                {StackObject.VarType,  new StackAction(StackObject.VarType, 47)},
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 20)},
                {StackObject.AttributionNT,  new TransitionAction(46)},
                {StackObject.CheeenAttributionNT,  new TransitionAction(45)}
            },

            #endregion

            #region State 30

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Text,  new StackAction(StackObject.Text, 48)}
            },

            #endregion

            #region State 31

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Text,  new StackAction(StackObject.Text, 49)}
            },

            #endregion

            #region State 32

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(50)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 33

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 54)}
            },

            #endregion

            #region State 34

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(55)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 35

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 56)}
            },

            #endregion

            #region State 36

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.BoolExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new StackAction(StackObject.BoolExpressionAuxNT)},
                {StackObject.And,  new StackAction(StackObject.And, 58)},
                {StackObject.Or,  new StackAction(StackObject.Or, 59)},
                {StackObject.Xor,  new StackAction(StackObject.Xor, 60)},
                {StackObject.BoolExpressionAuxNT,  new TransitionAction(57)}
            },

            #endregion

            #region State 37

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(61)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 38

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(62)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 39

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.True)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.True)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.True)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.True)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.True)},
            },

            #endregion

            #region State 40

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.False)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.False)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.False)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.False)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.False)},
            },

            #endregion

            #region State 41

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Greater,  new StackAction(StackObject.Greater, 64)},
                {StackObject.GreaterEquals,  new StackAction(StackObject.GreaterEquals, 65)},
                {StackObject.Lower,  new StackAction(StackObject.Lower, 66)},
                {StackObject.LowerEquals,  new StackAction(StackObject.LowerEquals, 67)},
                {StackObject.EqualsTerminal,  new StackAction(StackObject.EqualsTerminal, 68)},
                {StackObject.Different,  new StackAction(StackObject.Different, 69)},
                {StackObject.RelationalExpressionAuxNT,  new TransitionAction(63)}
            },

            #endregion

            #region State 42

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.And,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Or,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Xor,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Sum,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Substract,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Multiply,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Division,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Modulus,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Greater,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.GreaterEquals,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Lower,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.LowerEquals,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.EqualsTerminal,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)},
                {StackObject.Different,  new ReduceAction(StackObject.ValueNT, StackObject.Immediate)}
            },

            #endregion

            #region State 43

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.And,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Or,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Xor,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Sum,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Substract,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Multiply,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Division,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Modulus,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Greater,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.GreaterEquals,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Lower,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.LowerEquals,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.EqualsTerminal,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)},
                {StackObject.Different,  new ReduceAction(StackObject.ValueNT, StackObject.Identifier)}
            },

            #endregion

            #region State 44

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 70)}
            },

            #endregion

            #region State 45

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 71)}
            },

            #endregion

            #region State 46

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.CheeenAttributionNT, StackObject.AttributionNT)}
            },

            #endregion

            #region State 47

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 20)},
                {StackObject.AttributionNT,  new TransitionAction(72)}
            },

            #endregion

            #region State 48

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 73)}
            },

            #endregion

            #region State 49

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 74)}
            },

            #endregion

            #region State 50

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.AttributionNT, StackObject.Identifier, StackObject.Assignment, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.AttributionNT, StackObject.Identifier, StackObject.Assignment, StackObject.ExpressionNT)},
            },

            #endregion

            #region State 51

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.ExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new StackAction(StackObject.ExpressionAuxNT)},
                {StackObject.Sum,  new StackAction(StackObject.Sum, 76)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 77)},
                {StackObject.Multiply,  new StackAction(StackObject.Multiply, 78)},
                {StackObject.Division,  new StackAction(StackObject.Division, 79)},
                {StackObject.Modulus,  new StackAction(StackObject.Modulus, 80)},
                {StackObject.ExpressionAuxNT,  new TransitionAction(75)}
            },

            #endregion

            #region State 52

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(81)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 53

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(82)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 54

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.DeclVariableNT, StackObject.VarType, StackObject.Identifier, StackObject.DeclVariableAuxNT, StackObject.Semicolon)},
            },

            #endregion

            #region State 55

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.DeclVariableAuxNT, StackObject.Assignment, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 56

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenBracket,  new StackAction(StackObject.OpenBracket, 83)}
            },

            #endregion

            #region State 57

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.RelationalExpressionNT, StackObject.BoolExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.RelationalExpressionNT, StackObject.BoolExpressionAuxNT)}
            },

            #endregion

            #region State 58

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(84)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 59

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(85)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 60

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(86)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 61

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.Not, StackObject.BoolExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.Not, StackObject.BoolExpressionNT)}
            },

            #endregion

            #region State 62

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 87)}
            },

            #endregion

            #region State 63

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.ValueNT, StackObject.RelationalExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.ValueNT, StackObject.RelationalExpressionAuxNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.ValueNT, StackObject.RelationalExpressionAuxNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.ValueNT, StackObject.RelationalExpressionAuxNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionNT, StackObject.ValueNT, StackObject.RelationalExpressionAuxNT)}
            },

            #endregion

            #region State 64

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(88)}
            },

            #endregion

            #region State 65

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(89)}
            },

            #endregion

            #region State 66

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(90)}
            },

            #endregion

            #region State 67

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(91)}
            },

            #endregion

            #region State 68

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(92)}
            },

            #endregion

            #region State 69

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.ValueNT,  new TransitionAction(93)}
            },

            #endregion

            #region State 70

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenBracket,  new StackAction(StackObject.OpenBracket, 94)}
            },

            #endregion

            #region State 71

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 38)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Not,  new StackAction(StackObject.Not, 37)},
                {StackObject.True,  new StackAction(StackObject.True, 39)},
                {StackObject.False,  new StackAction(StackObject.False, 40)},
                {StackObject.BoolExpressionNT,  new TransitionAction(95)},
                {StackObject.RelationalExpressionNT,  new TransitionAction(36)},
                {StackObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 72

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.CheeenAttributionNT, StackObject.VarType, StackObject.AttributionNT)}
            },

            #endregion

            #region State 73

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 96)}
            },

            #endregion

            #region State 74

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 97)}
            },

            #endregion

            #region State 75

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionNT, StackObject.ValueNT, StackObject.ExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionNT, StackObject.ValueNT, StackObject.ExpressionAuxNT)}
            },

            #endregion

            #region State 76

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(98)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 77

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(99)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 78

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(100)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 79

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(101)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 80

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 43)},
                {StackObject.OpenParenthesis,  new StackAction(StackObject.OpenParenthesis, 52)},
                {StackObject.Immediate,  new StackAction(StackObject.Immediate, 42)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 53)},
                {StackObject.ExpressionNT,  new TransitionAction(102)},
                {StackObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 81

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 103)}
            },

            #endregion

            #region State 82

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionNT, StackObject.Substract, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionNT, StackObject.Substract, StackObject.ExpressionNT)},
            },

            #endregion

            #region State 83

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(104) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 84

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.And, StackObject.BoolExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.And, StackObject.BoolExpressionNT)}
            },

            #endregion

            #region State 85

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.Or, StackObject.BoolExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.Or, StackObject.BoolExpressionNT)}
            },

            #endregion

            #region State 86

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.Xor, StackObject.BoolExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionAuxNT, StackObject.Xor, StackObject.BoolExpressionNT)}
            },

            #endregion

            #region State 87

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.BoolExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new StackAction(StackObject.BoolExpressionAuxNT)},
                {StackObject.And,  new StackAction(StackObject.And, 58)},
                {StackObject.Or,  new StackAction(StackObject.Or, 59)},
                {StackObject.Xor,  new StackAction(StackObject.Xor, 60)},
                {StackObject.BoolExpressionAuxNT, new TransitionAction(120) }
            },

            #endregion

            #region State 88

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Greater, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Greater, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Greater, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Greater, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Greater, StackObject.ValueNT)}
            },

            #endregion

            #region State 89

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.GreaterEquals, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.GreaterEquals, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.GreaterEquals, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.GreaterEquals, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.GreaterEquals, StackObject.ValueNT)}
            },

            #endregion

            #region State 90

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Lower, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Lower, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Lower, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Lower, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Lower, StackObject.ValueNT)}
            },

            #endregion

            #region State 91

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.LowerEquals, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.LowerEquals, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.LowerEquals, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.LowerEquals, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.LowerEquals, StackObject.ValueNT)}
            },

            #endregion

            #region State 92

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.EqualsTerminal, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.EqualsTerminal, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.EqualsTerminal, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.EqualsTerminal, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.EqualsTerminal, StackObject.ValueNT)}
            },

            #endregion

            #region State 93

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Different, StackObject.ValueNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Different, StackObject.ValueNT)},
                {StackObject.And,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Different, StackObject.ValueNT)},
                {StackObject.Or,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Different, StackObject.ValueNT)},
                {StackObject.Xor,  new ReduceAction(StackObject.RelationalExpressionAuxNT, StackObject.Different, StackObject.ValueNT)}
            },

            #endregion

            #region State 94

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(105) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 95

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.Semicolon, 106)}
            },

            #endregion

            #region State 96

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.MarisaNT, StackObject.Marisa, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
            },

            #endregion

            #region State 97

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Cirno,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Mokou,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Marisa,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Stb,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Honk,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Pedal,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.VarType,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.Identifier,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.StbNT, StackObject.Stb, StackObject.OpenParenthesis, StackObject.Text, StackObject.CloseParenthesis, StackObject.Semicolon)},
            },

            #endregion

            #region State 98

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Sum, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Sum, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 99

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Substract, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Substract, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 100

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Multiply, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Multiply, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 101

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Division, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Division, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 102

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Modulus, StackObject.ExpressionNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionAuxNT, StackObject.Modulus, StackObject.ExpressionNT)}
            },

            #endregion

            #region State 103

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new StackAction(StackObject.ExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new StackAction(StackObject.ExpressionAuxNT)},
                {StackObject.Sum,  new StackAction(StackObject.Sum, 76)},
                {StackObject.Substract,  new StackAction(StackObject.Substract, 77)},
                {StackObject.Multiply,  new StackAction(StackObject.Multiply, 78)},
                {StackObject.Division,  new StackAction(StackObject.Division, 79)},
                {StackObject.Modulus,  new StackAction(StackObject.Modulus, 80)},
                {StackObject.ExpressionAuxNT,  new TransitionAction(121)},
            },

            #endregion

            #region State 104

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseBracket,  new StackAction(StackObject.CloseBracket, 107)}
            },

            #endregion

            #region State 105

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseBracket,  new StackAction(StackObject.CloseBracket, 108)}
            },

            #endregion

            #region State 106

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CheeenExpressionNT)},
                {StackObject.Identifier,  new StackAction(StackObject.Identifier, 20)},
                {StackObject.AttributionNT,  new TransitionAction(110)},
                {StackObject.CheeenExpressionNT,  new TransitionAction(109)}
            },

            #endregion

            #region State 107

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Honk, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Pedal, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.VarType, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Identifier, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Cirno, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Mokou, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Cheeen, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Marisa, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Stb, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.CloseBracket, new StackAction(StackObject.CirnoAuxNT) },
                {StackObject.Baka, new StackAction(StackObject.Baka, 112) },
                {StackObject.CirnoAuxNT, new TransitionAction(111) }
            }, 

            #endregion

            #region State 108

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cirno,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Mokou,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Marisa,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Stb,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Honk,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Pedal,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.VarType,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Identifier,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.MokouNT, StackObject.Mokou, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)}
            },

            #endregion

            #region State 109

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new StackAction(StackObject.CloseParenthesis, 113)}
            },

            #endregion

            #region State 110

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.CheeenExpressionNT, StackObject.AttributionNT)}
            },

            #endregion

            #region State 111

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Cirno,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Mokou,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Marisa,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Stb,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Honk,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Pedal,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.VarType,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.Identifier,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.CirnoNT, StackObject.Cirno, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket, StackObject.CirnoAuxNT)}
            },

            #endregion

            #region State 112

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenBracket,  new StackAction(StackObject.OpenBracket, 114)}
            },

            #endregion

            #region State 113

            new Dictionary<StackObject, IAction>
            {
                {StackObject.OpenBracket,  new StackAction(StackObject.OpenBracket, 115)}
            },

            #endregion

            #region State 114

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(116) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 115

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani, new StackAction(StackObject.StatementNT) },
                {StackObject.Honk, new StackAction(StackObject.Honk, 12) },
                {StackObject.Pedal, new StackAction(StackObject.Pedal, 13) },
                {StackObject.VarType, new StackAction(StackObject.VarType, 14) },
                {StackObject.Identifier, new StackAction(StackObject.Identifier, 20) },
                {StackObject.Cirno, new StackAction(StackObject.Cirno, 15) },
                {StackObject.Mokou, new StackAction(StackObject.Mokou, 16) },
                {StackObject.Cheeen, new StackAction(StackObject.Cheeen, 17) },
                {StackObject.Marisa, new StackAction(StackObject.Marisa, 18) },
                {StackObject.Stb, new StackAction(StackObject.Stb, 19) },
                {StackObject.CloseBracket, new StackAction(StackObject.StatementNT) },
                {StackObject.StatementNT, new TransitionAction(117) },
                {StackObject.StatementAuxNT, new TransitionAction(4) },
                {StackObject.DeclVariableNT, new TransitionAction(5) },
                {StackObject.CirnoNT, new TransitionAction(6) },
                {StackObject.MokouNT, new TransitionAction(7) },
                {StackObject.CheeenNT, new TransitionAction(8) },
                {StackObject.MarisaNT, new TransitionAction(9) },
                {StackObject.StbNT, new TransitionAction(10) },
                {StackObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 116

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseBracket,  new StackAction(StackObject.CloseBracket, 118)}
            },

            #endregion

            #region State 117

            new Dictionary<StackObject, IAction>
            {
                {StackObject.CloseBracket,  new StackAction(StackObject.CloseBracket, 119)}
            },

            #endregion

            #region State 118

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cirno,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Mokou,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Marisa,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Stb,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Honk,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Pedal,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.VarType,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Identifier,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.CirnoAuxNT, StackObject.Baka, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)}
            },

            #endregion

            #region State 119

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Nani,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cirno,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Mokou,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Cheeen,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Marisa,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Stb,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Honk,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Pedal,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.VarType,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.Identifier,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)},
                {StackObject.CloseBracket,  new ReduceAction(StackObject.CheeenNT, StackObject.Cheeen, StackObject.OpenParenthesis, StackObject.CheeenAttributionNT, StackObject.Semicolon, StackObject.BoolExpressionNT, StackObject.Semicolon, StackObject.CheeenExpressionNT, StackObject.CloseParenthesis, StackObject.OpenBracket, StackObject.StatementNT, StackObject.CloseBracket)}
            },

            #endregion

            #region State 120

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.BoolExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.BoolExpressionNT, StackObject.OpenParenthesis, StackObject.BoolExpressionNT, StackObject.CloseParenthesis, StackObject.BoolExpressionAuxNT)},
            },

            #endregion

            #region State 121

            new Dictionary<StackObject, IAction>
            {
                {StackObject.Semicolon,  new ReduceAction(StackObject.ExpressionNT, StackObject.OpenParenthesis, StackObject.ExpressionNT, StackObject.CloseParenthesis, StackObject.ExpressionAuxNT)},
                {StackObject.CloseParenthesis,  new ReduceAction(StackObject.ExpressionNT, StackObject.OpenParenthesis, StackObject.ExpressionNT, StackObject.CloseParenthesis, StackObject.ExpressionAuxNT)},
            },

            #endregion
        };
    }
}