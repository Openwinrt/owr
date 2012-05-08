namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6a79e863, 0x4300, 0x459a, 0x99, 0x66, 0xcb, 0xb6, 0x60, 150, 0x3e, 0xe1)]
    public interface IIterator<T>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        uint GetMany([Out, LengthIs((uint) 0)] T[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool MoveNext();

        T Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        bool HasCurrent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

