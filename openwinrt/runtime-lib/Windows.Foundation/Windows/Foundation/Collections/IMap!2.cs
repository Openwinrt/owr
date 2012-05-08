namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3c2925fe, 0x8519, 0x45c1, 170, 0x79, 0x19, 0x7b, 0x67, 0x18, 0xc1, 0xc1), Version(0x6020000)]
    public interface IMap<K, V> : IIterable<IKeyValuePair<K, V>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        IMapView<K, V> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool HasKey([In] K key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        bool Insert([In] K key, [In] V value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        V Lookup([In] K key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Remove([In] K key);

        uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

