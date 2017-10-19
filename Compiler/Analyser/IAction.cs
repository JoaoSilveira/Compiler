using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Analyser
{
    public interface IAction
    {
        void Resolve(Stack<QueueObject> actions, Stack<int> states);
    }
}
