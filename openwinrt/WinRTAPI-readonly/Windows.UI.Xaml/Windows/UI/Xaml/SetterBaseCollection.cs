namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Activatable(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class SetterBaseCollection : ISetterBaseCollection, IVector<SetterBase>, IIterable<SetterBase>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SetterBaseCollection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] SetterBase value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<SetterBase> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SetterBase GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] SetterBase[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<SetterBase> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] SetterBase value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] SetterBase value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] SetterBase[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] SetterBase value);

        public bool IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.ISetterBaseCollection.IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

