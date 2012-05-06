namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceQualifierObservableMap : IObservableMap<string, string>, IMap<string, string>, IIterable<IKeyValuePair<string, string>>
    {
        public event MapChangedEventHandler<string, string> MapChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, string>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<string, string> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] string key, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] string key);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

