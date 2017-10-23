using System;
using System.Collections.Generic;
using System.Linq;
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
                var so = new StackObject((long)tkn.Type, true, tkn.Line, tkn.Column);

                while (!stream.EndOfStream)
                {
                    int ans;
                    IAction transition;

                    Console.WriteLine("===========================================");
                    Console.WriteLine("{0,10}\t" + string.Join(", ", objects.Select(p => p.ToString())), "Pilha:");
                    Console.WriteLine("{0,10}\t" + string.Join(", ", states.Select(p => p.ToString())), "Estados:");
                    Console.WriteLine("{0,10}\t" + so, "Next:");
                    Console.WriteLine("===========================================");

                    try
                    {
                        transition = States.StateArray[states.Peek()][so];
                        ans = transition.Resolve(objects, states);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new Exception($"Invalid state {states.Peek()}");
                    }
                    catch (KeyNotFoundException)
                    {
                        throw new Exception($"Unexpected {so} at line {so.Line} column {so.Column}.\nPossible transitions: {string.Join("\n", States.StateArray[states.Peek()].Keys.Select(p => p.ToString()))}");
                    }

                    switch (ans)
                    {
                        case 0:
                            tkn = stream.Read();

                            var type = tkn.Type;

                            if ((tkn.Type & TokenType.VarType) != 0)
                            {
                                type = TokenType.VarType;
                            }

                            if ((tkn.Type & TokenType.Immediate) != 0)
                            {
                                type = TokenType.Immediate;
                            }

                            if ((tkn.Type & TokenType.Identifier) != 0)
                            {
                                type = TokenType.Identifier;
                            }

                            so = new StackObject((long)type, true, tkn.Line, tkn.Column);
                            break;
                        case 1:
                            so = transition.Data;
                            break;
                        case 2:

                            type = tkn.Type;

                            if ((tkn.Type & TokenType.VarType) != 0)
                            {
                                type = TokenType.VarType;
                            }

                            if ((tkn.Type & TokenType.Immediate) != 0)
                            {
                                type = TokenType.Immediate;
                            }

                            if ((tkn.Type & TokenType.Identifier) != 0)
                            {
                                type = TokenType.Identifier;
                            }

                            so = new StackObject((long)type, true, tkn.Line, tkn.Column);
                            break;
                        default:
                            throw new Exception("Something went really bad");
                    }
                }
            }
        }
    }
}