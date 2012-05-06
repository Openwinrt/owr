namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(ScrollBarAutomationPeer)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe1302110, 0xafeb, 0x4595, 0x8e, 0x3d, 0xed, 0xc0, 0x84, 0x4a, 0x2b, 0x21)]
    internal interface IScrollBarAutomationPeerFactory
    {
        ScrollBarAutomationPeer CreateInstanceWithOwner([In] ScrollBar owner, [In] object outer, out object inner);
    }
}

