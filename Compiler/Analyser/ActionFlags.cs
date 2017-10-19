using System;

namespace Compiler.Analyser
{
    [Flags]
    public enum ActionFlags
    {
        Push = 0x1,
        Trasition = 0x2,
        Reduce = 0x4,
        PushAndTransition = Push | Trasition
    }
}