namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe480ce40, 0xa338, 0x4ada, 0xad, 0xcf, 0x27, 0x22, 0x72, 0xe4, 140, 0xb9)]
    public interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool HasKey([In] K key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        V Lookup([In] K key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Split(out IMapView<K, V> first, out IMapView<K, V> second);

        uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

