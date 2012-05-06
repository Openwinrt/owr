namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceMap : IResourceMap, IMapView<string, NamedResource>, IIterable<IKeyValuePair<string, NamedResource>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, NamedResource>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceMap GetSubtree([In] string reference);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetValue")]
        public ResourceCandidate GetValue([In] string resource);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetValueForContext")]
        public ResourceCandidate GetValue([In] string resource, [In] ResourceContext context);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NamedResource Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Split(out IMapView<string, NamedResource> first, out IMapView<string, NamedResource> second);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.Uri Windows.ApplicationModel.Resources.Core.IResourceMap.Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

