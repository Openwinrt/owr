namespace Windows.ApplicationModel.Resources.Core
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ResourceContext)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x98be9d6c, 0x6338, 0x4b31, 0x99, 0xdf, 0xb2, 180, 0x42, 0xf1, 0x71, 0x49)]
    internal interface IResourceContextStatics
    {
        ResourceContext CreateMatchingContext([In] IIterable<ResourceQualifier> result);
    }
}

