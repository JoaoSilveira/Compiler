using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Analyser
{
    public interface IAction
    {
        StackObject Data { get; }
        int Resolve(Stack<StackObject> actions, Stack<int> states);
    }
}
