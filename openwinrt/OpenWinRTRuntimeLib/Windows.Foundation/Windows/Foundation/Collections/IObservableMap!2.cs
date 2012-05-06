namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x65df2bf5, 0xbf39, 0x41b5, 0xae, 0xbc, 90, 0x9d, 0x86, 0x5e, 0x47, 0x2b)]
    public interface IObservableMap<K, V> : IMap<K, V>
    {
        event MapChangedEventHandler<K, V> MapChanged;
    }
}

