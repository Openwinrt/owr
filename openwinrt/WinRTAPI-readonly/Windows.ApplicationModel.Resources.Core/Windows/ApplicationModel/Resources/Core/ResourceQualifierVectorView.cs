namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceQualifierVectorView : IVectorView<ResourceQualifier>, IIterable<ResourceQualifier>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<ResourceQualifier> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceQualifier GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] ResourceQualifier[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] ResourceQualifier value, out uint index);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

