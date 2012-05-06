namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0xbd5eb663, 0x2c14, 0x4665, 0xad, 0xef, 0xf2, 0xb0, 0x33, 0x94, 0x7b, 0xeb), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(RichTextBlockOverflowAutomationPeer))]
    internal interface IRichTextBlockOverflowAutomationPeerFactory
    {
        RichTextBlockOverflowAutomationPeer CreateInstanceWithOwner([In] RichTextBlockOverflow owner, [In] object outer, out object inner);
    }
}

