using System;
using System.Collections.Generic;

namespace Compiler.Analyser
{
    public class TransitionAction : IAction
    {
        public int State { get; }

        public StackObject Data => throw new Exception("Transition has no data");

        public TransitionAction(int state)
        {
            State = state;
        }

        public int Resolve(Stack<StackObject> actions, Stack<int> states)
        {
            states.Push(State);

            return 0;
        }
    }
}