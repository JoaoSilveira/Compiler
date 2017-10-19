using System;
using System.Collections.Generic;
using System.Linq;

namespace Compiler.Analyser
{
    public class ReduceAction : IAction
    {
        public QueueObject[] ReduceStack { get; }

        public QueueObject NonTerminal { get; }

        public ReduceAction(QueueObject nonTerminal, params QueueObject[] reduceStack)
        {
            NonTerminal = nonTerminal;
            ReduceStack = reduceStack;
        }

        public void Resolve(Stack<QueueObject> actions, Stack<int> states)
        {
            foreach (var queueObject in ReduceStack.Reverse())
            {
                if (!queueObject.Equals(actions.Peek()))
                {
                    throw new Exception("Handle error someday");
                }

                actions.Pop();
                states.Pop();
            }
            actions.Push(NonTerminal);
        }
    }
}