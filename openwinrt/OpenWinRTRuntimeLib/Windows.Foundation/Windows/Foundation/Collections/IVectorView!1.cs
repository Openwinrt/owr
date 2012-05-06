namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xbbe1fa4c, 0xb0e3, 0x4583, 0xba, 0xef, 0x1f, 0x1b, 0x2e, 0x48, 0x3e, 0x56), Version(0x6020000)]
    public interface IVectorView<T> : IIterable<T>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        T GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        uint GetMany([In] uint startIndex, [Out, LengthIs((uint) 0)] T[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool IndexOf([In] T value, out uint index);

        uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

