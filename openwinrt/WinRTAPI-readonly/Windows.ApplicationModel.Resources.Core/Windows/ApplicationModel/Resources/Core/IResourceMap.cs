namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ResourceMap)), Windows.Foundation.Metadata.Guid(0x72284824, 0xdb8c, 0x42f8, 0xb0, 140, 0x53, 0xff, 0x35, 0x7d, 0xad, 130)]
    internal interface IResourceMap : IMapView<string, NamedResource>, IIterable<IKeyValuePair<string, NamedResource>>
    {
        ResourceMap GetSubtree([In] string reference);
        [Overload("GetValue")]
        ResourceCandidate GetValue([In] string resource);
        [Overload("GetValueForContext")]
        ResourceCandidate GetValue([In] string resource, [In] ResourceContext context);

        Windows.Foundation.Uri Uri { get; }
    }
}

