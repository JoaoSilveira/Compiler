using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compiler.Token;

namespace Compiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                    throw new Exception("File path should be provided as command line argument");

                if (!File.Exists(args[0]))
                    throw new Exception("Inexistent file");

                using (var stream = new TokenStream(args[0]))
                {
                    while (!stream.EndOfStream)
                    {
                        Console.WriteLine(stream.Read());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
