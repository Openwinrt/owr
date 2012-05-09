    using System;

namespace Windows.Foundation.Metadata
{


    [Flags, Version(0x6020000)]
    public enum AttributeTargets : uint
    {
        All = 0xffffffff,
        Delegate = 1,
        Enum = 2,
        Event = 4,
        Field = 8,
        Interface = 0x10,
        InterfaceGroup = 0x20,
        InterfaceImpl = 0x800,
        Method = 0x40,
        Parameter = 0x80,
        Property = 0x100,
        RuntimeClass = 0x200,
        Struct = 0x400
    }
}

