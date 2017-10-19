using System;
using System.Collections.Generic;
using System.Linq;

namespace Compiler.Analyser
{
    public class ReduceAction : IAction
    {
        public StackObject[] ReduceStack { get; }

        public StackObject NonTerminal { get; }

        public StackObject Data => NonTerminal;

        public ReduceAction(StackObject nonTerminal, params StackObject[] reduceStack)
        {
            NonTerminal = nonTerminal;
            ReduceStack = reduceStack;
        }

        public int Resolve(Stack<StackObject> actions, Stack<int> states)
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

            return 1;
        }
    }
}