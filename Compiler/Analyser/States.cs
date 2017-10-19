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

            #region State 42

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.And,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Or,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Sum,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Substract,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Multiply,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Division,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Modulus,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Greater,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.GreaterEquals,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Lower,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.LowerEquals,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.EqualsTerminal,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)},
                {QueueObject.Different,  new ReduceAction(QueueObject.ValueNT, QueueObject.Immediate)}
            },

            #endregion

            #region State 43

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.And,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Or,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Sum,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Substract,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Multiply,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Division,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Modulus,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Greater,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.GreaterEquals,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Lower,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.LowerEquals,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.EqualsTerminal,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)},
                {QueueObject.Different,  new ReduceAction(QueueObject.ValueNT, QueueObject.Identifier)}
            },

            #endregion

            #region State 44

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 70)}
            },

            #endregion

            #region State 45

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 71)}
            },

            #endregion

            #region State 46

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.CheeenAttributionNT, QueueObject.AttributionNT)}
            },

            #endregion

            #region State 47

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 20)},
                {QueueObject.AttributionNT,  new TransitionAction(72)}
            },

            #endregion

            #region State 48

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 73)}
            },

            #endregion

            #region State 49

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 74)}
            },

            #endregion

            #region State 50

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.AttributionNT, QueueObject.Identifier, QueueObject.Assignment, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.AttributionNT, QueueObject.Identifier, QueueObject.Assignment, QueueObject.ExpressionNT)},
            },

            #endregion

            #region State 51

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.ExpressionAuxNT)},
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.ExpressionAuxNT)},
                {QueueObject.Sum,  new QueueAction(QueueObject.Sum, 76)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 77)},
                {QueueObject.Multiply,  new QueueAction(QueueObject.Multiply, 78)},
                {QueueObject.Division,  new QueueAction(QueueObject.Division, 79)},
                {QueueObject.Modulus,  new QueueAction(QueueObject.Modulus, 80)},
                {QueueObject.ExpressionAuxNT,  new TransitionAction(75)}
            },

            #endregion

            #region State 52

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(81)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 53

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(82)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 54

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.DeclVariableNT, QueueObject.VarType, QueueObject.Identifier, QueueObject.DeclVariableAuxNT, QueueObject.Semicolon)},
            },

            #endregion

            #region State 55

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.DeclVariableAuxNT, QueueObject.Assignment, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 56

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenBracket,  new QueueAction(QueueObject.OpenBracket, 83)}
            },

            #endregion

            #region State 57

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.RelationalExpressionNT, QueueObject.BoolExpressionAuxNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.RelationalExpressionNT, QueueObject.BoolExpressionAuxNT)}
            },

            #endregion

            #region State 58

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(84)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 59

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(85)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 60

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(86)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 61

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.Not, QueueObject.BoolExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.Not, QueueObject.BoolExpressionNT)}
            },

            #endregion

            #region State 62

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 87)}
            },

            #endregion

            #region State 63

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.ValueNT, QueueObject.RelationalExpressionAuxNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.ValueNT, QueueObject.RelationalExpressionAuxNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.ValueNT, QueueObject.RelationalExpressionAuxNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.ValueNT, QueueObject.RelationalExpressionAuxNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionNT, QueueObject.ValueNT, QueueObject.RelationalExpressionAuxNT)}
            },

            #endregion

            #region State 64

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(88)}
            },

            #endregion

            #region State 65

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(89)}
            },

            #endregion

            #region State 66

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(90)}
            },

            #endregion

            #region State 67

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(91)}
            },

            #endregion

            #region State 68

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(92)}
            },

            #endregion

            #region State 69

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Immediate, 43)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.ValueNT,  new TransitionAction(93)}
            },

            #endregion

            #region State 70

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenBracket,  new QueueAction(QueueObject.OpenBracket, 94)}
            },

            #endregion

            #region State 71

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 38)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Not,  new QueueAction(QueueObject.Not, 37)},
                {QueueObject.True,  new QueueAction(QueueObject.True, 39)},
                {QueueObject.False,  new QueueAction(QueueObject.False, 40)},
                {QueueObject.BoolExpressionNT,  new TransitionAction(95)},
                {QueueObject.RelationalExpressionNT,  new TransitionAction(36)},
                {QueueObject.ValueNT,  new TransitionAction(41)},
            },

            #endregion

            #region State 72

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.CheeenAttributionNT, QueueObject.VarType, QueueObject.AttributionNT)}
            },

            #endregion

            #region State 73

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 96)}
            },

            #endregion

            #region State 74

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 97)}
            },

            #endregion

            #region State 75

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionNT, QueueObject.ValueNT, QueueObject.ExpressionAuxNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionNT, QueueObject.ValueNT, QueueObject.ExpressionAuxNT)}
            },

            #endregion

            #region State 76

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(98)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 77

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(99)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 78

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(100)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 79

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(101)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 80

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 43)},
                {QueueObject.OpenParenthesis,  new QueueAction(QueueObject.OpenParenthesis, 52)},
                {QueueObject.Immediate,  new QueueAction(QueueObject.Immediate, 42)},
                {QueueObject.Substract,  new QueueAction(QueueObject.Substract, 53)},
                {QueueObject.ExpressionNT,  new TransitionAction(102)},
                {QueueObject.ValueNT,  new TransitionAction(51)}
            },

            #endregion

            #region State 81

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 103)}
            },

            #endregion

            #region State 82

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.CloseParenthesis, QueueObject.Substract, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.CloseParenthesis, QueueObject.Substract, QueueObject.ExpressionNT)},
            },

            #endregion

            #region State 83

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
                {QueueObject.StatementNT, new TransitionAction(104) },
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

            #region State 84

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.And, QueueObject.BoolExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.And, QueueObject.BoolExpressionNT)}
            },

            #endregion

            #region State 85

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.Or, QueueObject.BoolExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.Or, QueueObject.BoolExpressionNT)}
            },

            #endregion

            #region State 86

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.Xor, QueueObject.BoolExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionAuxNT, QueueObject.Xor, QueueObject.BoolExpressionNT)}
            },

            #endregion

            #region State 87

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.BoolExpressionNT, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis)}
            },

            #endregion

            #region State 88

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Greater, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Greater, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Greater, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Greater, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Greater, QueueObject.ValueNT)}
            },

            #endregion

            #region State 89

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.GreaterEquals, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.GreaterEquals, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.GreaterEquals, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.GreaterEquals, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.GreaterEquals, QueueObject.ValueNT)}
            },

            #endregion

            #region State 90

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Lower, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Lower, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Lower, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Lower, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Lower, QueueObject.ValueNT)}
            },

            #endregion

            #region State 91

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.LowerEquals, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.LowerEquals, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.LowerEquals, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.LowerEquals, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.LowerEquals, QueueObject.ValueNT)}
            },

            #endregion

            #region State 92

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.EqualsTerminal, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.EqualsTerminal, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.EqualsTerminal, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.EqualsTerminal, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.EqualsTerminal, QueueObject.ValueNT)}
            },

            #endregion

            #region State 93

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Different, QueueObject.ValueNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Different, QueueObject.ValueNT)},
                {QueueObject.And,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Different, QueueObject.ValueNT)},
                {QueueObject.Or,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Different, QueueObject.ValueNT)},
                {QueueObject.Xor,  new ReduceAction(QueueObject.RelationalExpressionAuxNT, QueueObject.Different, QueueObject.ValueNT)}
            },

            #endregion

            #region State 94

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
                {QueueObject.StatementNT, new TransitionAction(105) },
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

            #region State 95

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new QueueAction(QueueObject.Semicolon, 106)}
            },

            #endregion

            #region State 96

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.MarisaNT, QueueObject.Marisa, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
            },

            #endregion

            #region State 97

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.StbNT, QueueObject.Stb, QueueObject.OpenParenthesis, QueueObject.Text, QueueObject.CloseParenthesis, QueueObject.Semicolon)},
            },

            #endregion

            #region State 98

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Sum, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Sum, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 99

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Substract, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Substract, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 100

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Multiply, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Multiply, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 101

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Division, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Division, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 102

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Modulus, QueueObject.ExpressionNT)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionAuxNT, QueueObject.Modulus, QueueObject.ExpressionNT)}
            },

            #endregion

            #region State 103

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Semicolon,  new ReduceAction(QueueObject.ExpressionNT, QueueObject.OpenParenthesis, QueueObject.ExpressionNT, QueueObject.CloseParenthesis)},
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.ExpressionNT, QueueObject.OpenParenthesis, QueueObject.ExpressionNT, QueueObject.CloseParenthesis)}
            },

            #endregion

            #region State 104

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseBracket,  new QueueAction(QueueObject.CloseBracket, 107)}
            },

            #endregion

            #region State 105

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseBracket,  new QueueAction(QueueObject.CloseBracket, 108)}
            },

            #endregion

            #region State 106

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CheeenExpressionNT)},
                {QueueObject.Identifier,  new QueueAction(QueueObject.Identifier, 20)},
                {QueueObject.AttributionNT,  new TransitionAction(110)},
                {QueueObject.CheeenExpressionNT,  new TransitionAction(109)}
            },

            #endregion

            #region State 107

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Honk, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Pedal, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.VarType, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Identifier, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Cirno, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Mokou, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Cheeen, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Marisa, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Stb, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.CloseBracket, new QueueAction(QueueObject.CirnoAuxNT) },
                {QueueObject.Baka, new QueueAction(QueueObject.Baka, 112) },
                {QueueObject.CirnoAuxNT, new TransitionAction(111) }
            }, 

            #endregion

            #region State 108

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.MokouNT, QueueObject.Mokou, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)}
            },

            #endregion

            #region State 109

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new QueueAction(QueueObject.CloseParenthesis, 113)}
            },

            #endregion

            #region State 110

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseParenthesis,  new ReduceAction(QueueObject.CheeenExpressionNT, QueueObject.AttributionNT)}
            },

            #endregion

            #region State 111

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.CirnoNT, QueueObject.Cirno, QueueObject.OpenParenthesis, QueueObject.BoolExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket, QueueObject.CirnoAuxNT)}
            },

            #endregion

            #region State 112

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenBracket,  new QueueAction(QueueObject.OpenBracket, 114)}
            },

            #endregion

            #region State 113

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.OpenBracket,  new QueueAction(QueueObject.OpenBracket, 115)}
            },

            #endregion

            #region State 114

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
                {QueueObject.StatementNT, new TransitionAction(116) },
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

            #region State 115

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
                {QueueObject.StatementNT, new TransitionAction(117) },
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

            #region State 116

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseBracket,  new QueueAction(QueueObject.CloseBracket, 118)}
            },

            #endregion

            #region State 117

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.CloseBracket,  new QueueAction(QueueObject.CloseBracket, 119)}
            },

            #endregion

            #region State 118

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.CirnoAuxNT, QueueObject.Baka, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)}
            },

            #endregion

            #region State 119

            new Dictionary<QueueObject, IAction>
            {
                {QueueObject.Nani,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cirno,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Mokou,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Cheeen,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Marisa,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Stb,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Honk,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Pedal,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.VarType,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.Identifier,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)},
                {QueueObject.CloseBracket,  new ReduceAction(QueueObject.CheeenNT, QueueObject.Cheeen, QueueObject.OpenParenthesis, QueueObject.CheeenAttributionNT, QueueObject.Semicolon, QueueObject.BoolExpressionNT, QueueObject.Semicolon, QueueObject.CheeenExpressionNT, QueueObject.CloseParenthesis, QueueObject.OpenBracket, QueueObject.StatementNT, QueueObject.CloseBracket)}
            },

            #endregion

        };
    }
}