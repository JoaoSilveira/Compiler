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
            var aux = NonTerminal;
            foreach (var stackObject in ReduceStack.Reverse())
            {
                if (!stackObject.Equals(actions.Peek()))
                {
                    throw new Exception($"{stackObject} expected but found {actions.Peek()}");
                }

                aux = actions.Pop();
                states.Pop();
            }

            aux = new StackObject(NonTerminal.Data, NonTerminal.IsTerminal, aux.Line, aux.Column);
            actions.Push(aux);

            return 1;
        }
    }
}