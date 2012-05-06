namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x913337e9, 0x11a1, 0x4345, 0xa3, 0xa2, 0x4e, 0x7f, 0x95, 110, 0x22, 0x2d), Version(0x6020000)]
    public interface IVector<T> : IIterable<T>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Append([In] T value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        T GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        uint GetMany([In] uint startIndex, [Out, LengthIs((uint) 0)] T[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        IVectorView<T> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool IndexOf([In] T value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void InsertAt([In] uint index, [In] T value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void ReplaceAll([In] T[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void SetAt([In] uint index, [In] T value);

        uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

