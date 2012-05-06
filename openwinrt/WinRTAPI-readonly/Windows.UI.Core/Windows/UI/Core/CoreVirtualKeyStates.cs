namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Flags]
    public enum CoreVirtualKeyStates : uint
    {
        Down = 1,
        Locked = 2,
        None = 0
    }
}

