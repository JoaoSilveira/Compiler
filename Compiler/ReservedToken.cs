using System.Collections.Generic;
using System.Linq;

namespace Compiler
{
    public class ReservedToken : Token
    {
        private static readonly Dictionary<string, ReservedType> ReservedWords = new Dictionary<string, ReservedType>
        {
            {"JAOOOO", ReservedType.Jaoooo},
            {"cirno", ReservedType.Cirno},
            {"baka", ReservedType.Baka},
            {"cheeen", ReservedType.Cheeen},
            {"mokou", ReservedType.Mokou},
            {"honk", ReservedType.Honk},
            {"nani", ReservedType.Nani},
            {"pedal", ReservedType.Pedal},
            {"true", ReservedType.True},
            {"false", ReservedType.False},
            {"marisa", ReservedType.Marisa},
            {"std", ReservedType.Std},
            {"th1", ReservedType.Th1},
            {"th2", ReservedType.Th2},
            {"th4", ReservedType.Th4},
            {"th8", ReservedType.Th8},
            {"kk4", ReservedType.Kk4},
            {"kk8", ReservedType.Kk8}
        };

        public ReservedType ReservedType { get; }

        internal ReservedToken(string text) : base(text, TokenType.Reserved)
        {
            ReservedType = ReservedWords[text];
        }

        public static bool IsReservedWord(string word)
        {
            return ReservedWords.ContainsKey(word);
        }

        public override string ToString()
        {
            return $"<{ReservedType}>";
        }
    }
}