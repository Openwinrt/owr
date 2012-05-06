namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Activatable(0x6020000)]
    public sealed class GradientStopCollection : IVector<GradientStop>, IIterable<GradientStop>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GradientStopCollection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] GradientStop value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<GradientStop> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GradientStop GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] GradientStop[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<GradientStop> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] GradientStop value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] GradientStop value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] GradientStop[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] GradientStop value);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

