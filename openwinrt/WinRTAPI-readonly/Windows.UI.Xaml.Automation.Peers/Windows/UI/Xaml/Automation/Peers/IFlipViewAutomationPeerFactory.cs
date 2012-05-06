namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, ExclusiveTo(typeof(FlipViewAutomationPeer)), Windows.Foundation.Metadata.Guid(0x4395ab0d, 0x8d83, 0x483c, 0x88, 0xeb, 0xe2, 0x61, 0x7b, 13, 0x29, 0x3f), Version(0x6020000)]
    internal interface IFlipViewAutomationPeerFactory
    {
        FlipViewAutomationPeer CreateInstanceWithOwner([In] FlipView owner, [In] object outer, out object inner);
    }
}

