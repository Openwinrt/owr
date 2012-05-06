namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x179517f3, 0x94ee, 0x41f8, 0xbd, 220, 0x76, 0x8a, 0x89, 0x55, 0x44, 0xf3)]
    public delegate void MapChangedEventHandler<K, V>([In] IObservableMap<K, V> sender, [In] IMapChangedEventArgs<K> @event);
}

