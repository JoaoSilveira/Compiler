using System.Collections.Generic;
using Compiler.Token;

namespace Compiler.Analyser
{
    public static class States
    {
        public static readonly Dictionary<QueueObject, IAction>[] StateArray =
        {
            #region State 0

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Jaoooo, new QueueAction(QueueObject.Jaoooo, 2)},
                {QueueObject.BeginNT, new TransitionAction(1) }
            },

            #endregion

            #region State 1

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.End,  new AcceptAction()}
            },

            #endregion

            #region State 2

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani, new QueueAction(QueueObject.StatementNT) },
                {QueueObject.Honk, new QueueAction(QueueObject.Honk, 12) },
                {QueueObject.Pedal, new QueueAction(QueueObject.Pedal, 13) },
                {QueueObject.VarType, new QueueAction(QueueObject.VarType, 14) },
                {QueueObject.Identifier, new QueueAction(QueueObject.Identifier, 20) },
                {QueueObject.Cirno, new QueueAction(QueueObject.Cirno, 15) },
                {QueueObject.Mokou, new QueueAction(QueueObject.Mokou, 16) },
                {QueueObject.Cheeen, new QueueAction(QueueObject.Cheeen, 17) },
                {QueueObject.Marisa, new QueueAction(QueueObject.Marisa, 18) },
                {QueueObject.Stb, new QueueAction(QueueObject.Stb, 19) },
                {QueueObject.CloseBracket, new QueueAction(QueueObject.StatementNT) },
                {QueueObject.StatementNT, new TransitionAction(3) },
                {QueueObject.StatementAuxNT, new TransitionAction(4) },
                {QueueObject.DeclVariableNT, new TransitionAction(5) },
                {QueueObject.CirnoNT, new TransitionAction(6) },
                {QueueObject.MokouNT, new TransitionAction(7) },
                {QueueObject.CheeenNT, new TransitionAction(8) },
                {QueueObject.MarisaNT, new TransitionAction(9) },
                {QueueObject.StbNT, new TransitionAction(10) },
                {QueueObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 3

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new QueueAction(QueueObject.Nani, 21)}
            },

            #endregion

            #region State 4

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani, new QueueAction(QueueObject.StatementNT) },
                {QueueObject.Honk, new QueueAction(QueueObject.Honk, 12) },
                {QueueObject.Pedal, new QueueAction(QueueObject.Pedal, 13) },
                {QueueObject.VarType, new QueueAction(QueueObject.VarType, 14) },
                {QueueObject.Identifier, new QueueAction(QueueObject.Identifier, 20) },
                {QueueObject.Cirno, new QueueAction(QueueObject.Cirno, 15) },
                {QueueObject.Mokou, new QueueAction(QueueObject.Mokou, 16) },
                {QueueObject.Cheeen, new QueueAction(QueueObject.Cheeen, 17) },
                {QueueObject.Marisa, new QueueAction(QueueObject.Marisa, 18) },
                {QueueObject.Stb, new QueueAction(QueueObject.Stb, 19) },
                {QueueObject.CloseBracket, new QueueAction(QueueObject.StatementNT) },
                {QueueObject.StatementNT, new TransitionAction(22) },
                {QueueObject.StatementAuxNT, new TransitionAction(4) },
                {QueueObject.DeclVariableNT, new TransitionAction(5) },
                {QueueObject.CirnoNT, new TransitionAction(6) },
                {QueueObject.MokouNT, new TransitionAction(7) },
                {QueueObject.CheeenNT, new TransitionAction(8) },
                {QueueObject.MarisaNT, new TransitionAction(9) },
                {QueueObject.StbNT, new TransitionAction(10) },
                {QueueObject.AttributionNT, new TransitionAction(11) }
            }, 

            #endregion

            #region State 5

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.DeclVariableNT)},
            },

            #endregion

            #region State 6

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CirnoNT)},
            },

            #endregion

            #region State 7

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MokouNT)},
            },

            #endregion

            #region State 8

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.CheeenNT)},
            },

            #endregion

            #region State 9

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.MarisaNT)},
            },

            #endregion

            #region State 10

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.StbNT)},
            },

            #endregion

            #region State 11

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 23)}
            },

            #endregion

            #region State 12

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 24)}
            },

            #endregion

            #region State 13

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 25)}
            },

            #endregion

            #region State 14

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 26)}
            },

            #endregion

            #region State 15

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 27)}
            },

            #endregion

            #region State 16

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 28)}
            },

            #endregion

            #region State 17

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 29)}
            },

            #endregion

            #region State 18

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 30)}
            },

            #endregion

            #region State 19

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 31)}
            },

            #endregion

            #region State 20

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Assignment,  new QueueAction(QueueObject.Assignment, 32)}
            },

            #endregion

            #region State 21

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.End,  new ReduceAction(QueueObject.BeginNT, QueueObject.Jaoooo, QueueObject.StatementNT, QueueObject.Nani)}
            },

            #endregion

            #region State 22

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementNT, QueueObject.StatementAuxNT, QueueObject.StatementNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementNT, QueueObject.StatementAuxNT, QueueObject.StatementNT)}
            },

            #endregion

            #region State 23

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.AttributionNT, QueueObject.Semicolon)},
            },

            #endregion

            #region State 24

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Honk, QueueObject.Semicolon)},
            },

            #endregion

            #region State 25

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StatementAuxNT, QueueObject.Pedal, QueueObject.Semicolon)},
            },

            #endregion

            #region State 26

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.DeclVariableAuxNT)},
                {QueueObject.Assignment,  new QueueAction(QueueObject.Assignment, 34)},
                {QueueObject.DeclVariableAuxNT,  new TransitionAction(33)}
            },

            #endregion

            #region State 27

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(35)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 28

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(44)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 29

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.CheeenAttributionNT)},
                {QueueObject.VarType,  new QueueAction(QueueObject.VarType, 47)},
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 20)},
                {QueueObject.AttributionNT,  new TransitionAction(46)},
                {QueueObject.CheeenAttributionNT,  new TransitionAction(45)}
            },

            #endregion

            #region State 30

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Text,  new QueueAction(QueueObject.Text, 48)}
            },

            #endregion

            #region State 31

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Text,  new QueueAction(QueueObject.Text, 49)}
            },

            #endregion

            #region State 32

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(50)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 33

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 54)}
            },

            #endregion

            #region State 34

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(55)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 35

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 56)}
            },

            #endregion

            #region State 36

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.BoolExpressionAuxNT)},
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.BoolExpressionAuxNT)},
                {QueueObject.And,  new QueueAction(QueueObject.And, 58)},
                {QueueObject.Or,  new QueueAction(QueueObject.And, 59)},
                {QueueObject.Xor,  new QueueAction(QueueObject.And, 60)},
                {QueueObject.BoolExpressionAuxNT,  new TransitionAction(57)}
            },

            #endregion

            #region State 37

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(61)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 38

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(62)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)}
            },

            #endregion

            #region State 39

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.True)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.True)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.True)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.True)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.True)},
            },

            #endregion

            #region State 40

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.False)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.False)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.False)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.False)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.False)},
            },

            #endregion

            #region State 41

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Greater,  new QueueAction(QueueObject.Identifier, 64)},
                {QueueObject.GreaterEquals,  new QueueAction(QueueObject.Identifier, 65)},
                {QueueObject.Lower,  new QueueAction(QueueObject.Identifier, 66)},
                {QueueObject.LowerEquals,  new QueueAction(QueueObject.Identifier, 67)},
                {QueueObject.EqualsTerminal,  new QueueAction(QueueObject.Identifier, 68)},
                {QueueObject.Different,  new QueueAction(QueueObject.Identifier, 69)},
                {QueueObject.RelationalExpressionAuxNT,  new TransitionAction(63)}
            },

            #endregion
        };
    }
}