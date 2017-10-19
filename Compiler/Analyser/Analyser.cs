using System;
using System.Collections.Generic;
using Compiler.Token;

namespace Compiler.Analyser
{
    public class Analyser
    {
        public void Analyse(string file)
        {
            using (var stream = new TokenStream(file))
            {
                var objects = new Stack<StackObject>();
                var states = new Stack<int>();

                states.Push(0);

                var tkn = stream.Read();
                var so = new StackObject((long)tkn.Type, true);

                while (!stream.EndOfStream)
                {
                    var transition = States.StateArray[states.Peek()][so];
                    var ans = transition.Resolve(objects, states);

                    switch (ans)
                    {
                        case 0:
                            tkn = stream.Read();
                            so = new StackObject((long)tkn.Type, true);
                            break;
                        case 1:
                            so = transition.Data;
                            break;
                        default:
                            throw new Exception("Something went really bad");
                    }
                }
            }
        }
    }
}