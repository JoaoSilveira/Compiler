using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Analyser
{
    public class AcceptAction : IAction
    {
        public StackObject Data => throw new Exception("AcceptionAction has no data");

        int IAction.Resolve(Stack<StackObject> actions, Stack<int> states, StackObject? obj)
        {
            Console.WriteLine("Aceitou");
            return 3;
        }
    }
}
