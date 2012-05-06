namespace Windows.UI.Xaml.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(CustomXamlResourceLoader)), Windows.Foundation.Metadata.Guid(0x5bfd7e49, 0x7886, 0x44f3, 0x8e, 0xd3, 0x6f, 0xec, 4, 0x63, 0xed, 0x69), Version(0x6020000)]
    internal interface ICustomXamlResourceLoaderFactory
    {
        CustomXamlResourceLoader CreateInstance([In] object outer, out object inner);
    }
}

