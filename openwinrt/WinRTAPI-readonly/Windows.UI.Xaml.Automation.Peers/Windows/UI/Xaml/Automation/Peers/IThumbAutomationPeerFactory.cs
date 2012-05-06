namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(ThumbAutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x970743ff, 0xaf41, 0x4600, 0xb5, 0x5d, 0x26, 0xd4, 0x3d, 0xf8, 0x60, 0xe1), Version(0x6020000)]
    internal interface IThumbAutomationPeerFactory
    {
        ThumbAutomationPeer CreateInstanceWithOwner([In] Thumb owner, [In] object outer, out object inner);
    }
}

