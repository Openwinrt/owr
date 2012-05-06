namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000)]
    public sealed class PropertySet : IPropertySet, IObservableMap<string, object>, IMap<string, object>, IIterable<IKeyValuePair<string, object>>
    {
        public event MapChangedEventHandler<string, object> MapChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertySet();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, object>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<string, object> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] string key, [In] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] string key);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

