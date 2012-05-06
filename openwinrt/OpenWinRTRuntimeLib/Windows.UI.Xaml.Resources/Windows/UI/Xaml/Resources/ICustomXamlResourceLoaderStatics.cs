namespace Windows.UI.Xaml.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x224ff617, 0xe4dc, 0x4c27, 0xad, 50, 0xdb, 0x93, 0xd5, 0xd0, 0xe5, 0xda), ExclusiveTo(typeof(CustomXamlResourceLoader))]
    internal interface ICustomXamlResourceLoaderStatics
    {
        CustomXamlResourceLoader Current { get; [param: In] set; }
    }
}

