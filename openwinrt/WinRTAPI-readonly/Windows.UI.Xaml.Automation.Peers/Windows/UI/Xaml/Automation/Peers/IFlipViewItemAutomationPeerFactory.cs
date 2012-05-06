namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x69109356, 0xd0e5, 0x4c10, 160, 0x9c, 0xad, 11, 0xf1, 0xb0, 0xcb, 1), ExclusiveTo(typeof(FlipViewItemAutomationPeer)), WebHostHidden, Version(0x6020000)]
    internal interface IFlipViewItemAutomationPeerFactory
    {
        FlipViewItemAutomationPeer CreateInstanceWithOwner([In] FlipViewItem owner, [In] object outer, out object inner);
    }
}

