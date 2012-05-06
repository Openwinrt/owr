namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, ExclusiveTo(typeof(ComboBoxAutomationPeer)), Windows.Foundation.Metadata.Guid(0x98e5b0d, 0x1b90, 0x40b9, 0x9b, 0xe3, 0xb2, 50, 0x67, 0xeb, 0x13, 0xcf), Version(0x6020000)]
    internal interface IComboBoxAutomationPeerFactory
    {
        ComboBoxAutomationPeer CreateInstanceWithOwner([In] ComboBox owner, [In] object outer, out object inner);
    }
}

