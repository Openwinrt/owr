namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceQualifierMapView : IMapView<string, string>, IIterable<IKeyValuePair<string, string>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, string>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Split(out IMapView<string, string> first, out IMapView<string, string> second);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

