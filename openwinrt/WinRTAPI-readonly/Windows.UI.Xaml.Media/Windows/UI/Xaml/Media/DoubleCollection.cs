namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class DoubleCollection : IVector<double>, IIterable<double>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DoubleCollection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<double> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] double[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<double> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] double value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] double[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] double value);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

