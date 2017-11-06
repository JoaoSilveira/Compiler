using System;
using System.Collections.Generic;

namespace Compiler.Analyser
{
    public class StackAction : IAction
    {
        public TransitionAction Transition { get; }

        public StackObject Data { get; }

        public StackAction(StackObject stackObject)
        {
            Data = stackObject;
            Transition = null;
        }

        public StackAction(StackObject stackObject, int state)
        {
            Data = stackObject;
            Transition = new TransitionAction(state);
        }

        public int Resolve(Stack<StackObject> actions, Stack<int> states, StackObject? obj)
        {
            if (obj.HasValue)
                actions.Push(new StackObject(Data.Data, Data.IsTerminal, obj.Value.Line, obj.Value.Column));
            else
                throw new Exception("Obj not provided");

            Transition?.Resolve(actions, states);

            return Transition == null ? 1 : 0;
        }
    }
}