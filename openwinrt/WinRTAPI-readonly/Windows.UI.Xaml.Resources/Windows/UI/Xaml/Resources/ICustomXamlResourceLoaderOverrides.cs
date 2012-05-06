namespace Windows.UI.Xaml.Resources
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(CustomXamlResourceLoader)), Windows.Foundation.Metadata.Guid(0xf851e991, 0xaf02, 0x46e8, 0x9a, 0xf8, 0x42, 0x7b, 0x7e, 0xbf, 0xe9, 0xf8), Version(0x6020000)]
    internal interface ICustomXamlResourceLoaderOverrides
    {
        object GetResource([In] string resourceId, [In] string objectType, [In] string propertyName, [In] string propertyType);
    }
}

