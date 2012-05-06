namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class TransformCollection : IVector<Transform>, IIterable<Transform>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TransformCollection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] Transform value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<Transform> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Transform GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] Transform[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<Transform> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] Transform value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] Transform value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] Transform[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] Transform value);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

