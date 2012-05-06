namespace Windows.System
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum ProcessorArchitecture
    {
        Arm = 5,
        Neutral = 11,
        Unknown = 0xffff,
        X64 = 9,
        X86 = 0
    }
}

