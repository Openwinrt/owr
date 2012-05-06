namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ComboBoxItemDataAutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x14a8d4f6, 0x469a, 0x41ba, 0x9d, 0x93, 0x44, 0xa1, 0xa5, 0x5d, 0xa8, 0x72), Version(0x6020000)]
    internal interface IComboBoxItemDataAutomationPeerFactory
    {
        ComboBoxItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ComboBoxAutomationPeer parent, [In] object outer, out object inner);
    }
}

