namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ImageAutomationPeer)), Windows.Foundation.Metadata.Guid(0x90304003, 0x687d, 0x47bf, 0xb3, 0xa2, 0x4b, 0xab, 0xca, 0xd8, 0xef, 80)]
    internal interface IImageAutomationPeerFactory
    {
        ImageAutomationPeer CreateInstanceWithOwner([In] Image owner, [In] object outer, out object inner);
    }
}

