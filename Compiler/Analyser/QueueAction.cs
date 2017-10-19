using System.Collections.Generic;

namespace Compiler.Analyser
{
    public class QueueAction : IAction
    {
        public TransitionAction Transition { get; }

        public QueueObject Object { get; }

        public QueueAction(QueueObject queueObject)
        {
            Object = queueObject;
            Transition = null;
        }

        public QueueAction(QueueObject queueObject, int state)
        {
            Object = queueObject;
            Transition = new TransitionAction(state);
        }

        public void Resolve(Stack<QueueObject> actions, Stack<int> states)
        {
            actions.Push(Object);

            Transition?.Resolve(actions, states);
        }
    }
}