namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(TextBlockAutomationPeer)), Windows.Foundation.Metadata.Guid(0x76bf924b, 0x7ca0, 0x4b01, 0xbc, 0x5c, 0xa8, 0xcf, 0x4d, 0x36, 0x91, 0xde)]
    internal interface ITextBlockAutomationPeerFactory
    {
        TextBlockAutomationPeer CreateInstanceWithOwner([In] TextBlock owner, [In] object outer, out object inner);
    }
}

