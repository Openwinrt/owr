namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class PathFigureCollection : IVector<PathFigure>, IIterable<PathFigure>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PathFigureCollection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] PathFigure value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<PathFigure> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PathFigure GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] PathFigure[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<PathFigure> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] PathFigure value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] PathFigure value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] PathFigure[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] PathFigure value);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

