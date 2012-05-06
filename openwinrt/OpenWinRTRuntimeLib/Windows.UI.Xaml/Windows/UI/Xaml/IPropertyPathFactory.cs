namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4e4cdf99, 0x9826, 0x4e56, 0x84, 0x7c, 0xca, 5, 0x5f, 0x16, 0x29, 5), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(PropertyPath))]
    internal interface IPropertyPathFactory
    {
        PropertyPath CreateInstance([In] string path);
    }
}

