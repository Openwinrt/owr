namespace Windows.ApplicationModel.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8524908, 0x16ef, 0x45ad, 0xa6, 2, 0x29, 0x36, 0x37, 0xd7, 230, 0x1a), Version(0x6020000), ExclusiveTo(typeof(ResourceLoader))]
    internal interface IResourceLoader
    {
        string GetString([In] string resource);
    }
}

