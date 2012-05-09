


namespace System2.Runtime.CompilerServices
{

    [Flags]
    public enum MethodImplOptions
    {

        NoInlining = 8,

        NoOptimization = 64,

        PreserveSig = 128,

        AggressiveInlining = 256,

        // looks like some hidden options and others deprecated
    }
}
