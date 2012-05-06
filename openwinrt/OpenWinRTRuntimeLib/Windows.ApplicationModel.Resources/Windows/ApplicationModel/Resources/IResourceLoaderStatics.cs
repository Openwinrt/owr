namespace Windows.ApplicationModel.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xbf777ce1, 0x19c8, 0x49c2, 0x95, 60, 0x47, 0xe9, 0x22, 0x7b, 0x33, 0x4e), Version(0x6020000), ExclusiveTo(typeof(ResourceLoader))]
    internal interface IResourceLoaderStatics
    {
        string GetStringForReference([In] Uri uri);
    }
}

