namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(ListBoxAutomationPeer)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe2362185, 0x7df6, 0x49f7, 0x8a, 0xbc, 0x4c, 0x33, 0xf1, 0xa3, 0xd4, 110)]
    internal interface IListBoxAutomationPeerFactory
    {
        ListBoxAutomationPeer CreateInstanceWithOwner([In] ListBox owner, [In] object outer, out object inner);
    }
}

