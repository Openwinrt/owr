namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ListBoxItemDataAutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xd7924e16, 0xbd8d, 0x4662, 0xa9, 0x95, 0x20, 0xff, 0x9a, 5, 0x60, 0x93)]
    internal interface IListBoxItemDataAutomationPeerFactory
    {
        ListBoxItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ListBoxAutomationPeer parent, [In] object outer, out object inner);
    }
}

