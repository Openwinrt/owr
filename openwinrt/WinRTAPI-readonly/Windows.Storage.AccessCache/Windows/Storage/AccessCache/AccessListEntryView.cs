namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class AccessListEntryView : IVectorView<AccessListEntry>, IIterable<AccessListEntry>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<AccessListEntry> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AccessListEntry GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] AccessListEntry[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] AccessListEntry value, out uint index);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

