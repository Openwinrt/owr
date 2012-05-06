namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(RichTextBlockAutomationPeer)), Windows.Foundation.Metadata.Guid(0x2038ae61, 0x1389, 0x467a, 0xae, 0xd6, 0x37, 0x33, 0x4d, 0xa9, 0x62, 0x2b)]
    internal interface IRichTextBlockAutomationPeerFactory
    {
        RichTextBlockAutomationPeer CreateInstanceWithOwner([In] RichTextBlock owner, [In] object outer, out object inner);
    }
}

