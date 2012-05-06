namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3c864393, 0xaea, 0x4e78, 0xbc, 0x11, 0xb7, 0x75, 0xca, 0xc4, 0x11, 0x4c), ExclusiveTo(typeof(FlipViewItemDataAutomationPeer)), Version(0x6020000), WebHostHidden]
    internal interface IFlipViewItemDataAutomationPeerFactory
    {
        FlipViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] FlipViewAutomationPeer parent, [In] object outer, out object inner);
    }
}

