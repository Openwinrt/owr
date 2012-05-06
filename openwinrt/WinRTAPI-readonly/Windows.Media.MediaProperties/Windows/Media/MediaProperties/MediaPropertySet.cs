namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), HasVariant]
    public sealed class MediaPropertySet : IMap<Guid, object>, IIterable<IKeyValuePair<Guid, object>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<Guid, object>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<Guid, object> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] Guid key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] Guid key, [In] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object Lookup([In] Guid key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] Guid key);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

