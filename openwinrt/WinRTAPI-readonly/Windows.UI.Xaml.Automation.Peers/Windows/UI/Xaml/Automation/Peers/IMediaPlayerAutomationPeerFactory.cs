namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0xb9a4ed51, 0xe32d, 0x42be, 0x88, 0xc4, 0x40, 0x63, 0x24, 90, 0x36, 0x5f), ExclusiveTo(typeof(MediaPlayerAutomationPeer)), WebHostHidden, Version(0x6020000)]
    internal interface IMediaPlayerAutomationPeerFactory
    {
        MediaPlayerAutomationPeer CreateInstanceWithOwner([In] MediaPlayer owner, [In] object outer, out object inner);
    }
}

