using System.Collections.Generic;

namespace Compiler.Analyser
{
    public class TransitionAction : IAction
    {
        public int State { get; }

        public TransitionAction(int state)
        {
            State = state;
        }

        public void Resolve(Stack<QueueObject> actions, Stack<int> states)
        {
            states.Push(State);
        }
    }
}