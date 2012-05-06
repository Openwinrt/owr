namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9a03af92, 0x7d8a, 0x4937, 0x88, 0x4f, 0xec, 0xf3, 0x4f, 0xe0, 0x2a, 0xcb), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(DependencyObject))]
    internal interface IDependencyObjectFactory
    {
        DependencyObject CreateInstance([In] object outer, out object inner);
    }
}

