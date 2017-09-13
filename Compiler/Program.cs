using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compilador;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                    throw new Exception("File path should be provided as command line argument");

                if (!File.Exists(args[0]))
                    throw new Exception("Inexistent file");

                using (var file = new CustomStream(new StreamReader(File.OpenRead(args[0]))))
                {
                    var lex = new LexicalAnalyzer(file);

                    foreach (var token in lex.GetTokens())
                    {
                        Console.WriteLine(token);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
