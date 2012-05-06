namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(MediaElementAutomationPeer)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb2ad3b28, 0x7575, 0x4173, 0x9b, 0xc7, 0x80, 0x36, 0x7a, 0x16, 0x4e, 210)]
    internal interface IMediaElementAutomationPeerFactory
    {
        MediaElementAutomationPeer CreateInstanceWithOwner([In] MediaElement owner, [In] object outer, out object inner);
    }
}

