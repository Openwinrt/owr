namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x509f9dd8, 0xb0aa, 0x443f, 0xa1, 0x10, 0x41, 0x20, 0x9a, 0xf4, 0x4f, 0x1c), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ListBoxItemAutomationPeer))]
    internal interface IListBoxItemAutomationPeerFactory
    {
        ListBoxItemAutomationPeer CreateInstanceWithOwner([In] ListBoxItem owner, [In] object outer, out object inner);
    }
}

