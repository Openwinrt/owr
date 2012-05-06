namespace Windows.ApplicationModel.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc33a3603, 0x69dc, 0x4285, 160, 0x77, 0xd5, 0xc0, 0xe4, 0x7c, 0xcb, 0xe8), ExclusiveTo(typeof(ResourceLoader))]
    internal interface IResourceLoaderFactory
    {
        ResourceLoader CreateResourceLoaderByName([In] string name);
    }
}

