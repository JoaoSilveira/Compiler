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
            if (args.Length == 0)
                throw new Exception("Deve ser passado pelo menos um parametro");

            if (!File.Exists(args[0]))
                throw new Exception("Arquivo inexistente");

            using (var file = new CustomStream(new StreamReader(File.OpenRead(args[0]))))
            {
                var lex = new LexicalAnalyzer(file);

                foreach (var token in lex.GetTokens())
                {
                    Console.WriteLine(token.Text);
                }
            }
        }
    }
}
