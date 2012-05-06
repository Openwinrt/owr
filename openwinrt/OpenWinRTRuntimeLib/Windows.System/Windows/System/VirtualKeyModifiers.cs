namespace Windows.System
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum VirtualKeyModifiers : uint
    {
        Control = 1,
        Menu = 2,
        None = 0,
        Shift = 4,
        Windows = 8
    }
}

