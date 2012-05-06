namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CoreWindowFlyout)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xdec4c6c4, 0x93e8, 0x4f7c, 190, 0x27, 0xce, 250, 0xa1, 0xaf, 0x68, 0xa7)]
    internal interface ICoreWindowFlyoutFactory
    {
        CoreWindowFlyout Create([In] Point position);
        CoreWindowFlyout CreateWithTitle([In] Point position, [In] string title);
    }
}

