namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, ExclusiveTo(typeof(ComboBoxItemAutomationPeer)), Windows.Foundation.Metadata.Guid(0x134ac7fc, 0x397a, 0x403f, 0xa6, 0xec, 0x1c, 0xe8, 190, 0xda, 0x15, 0xe5), Version(0x6020000)]
    internal interface IComboBoxItemAutomationPeerFactory
    {
        ComboBoxItemAutomationPeer CreateInstanceWithOwner([In] ComboBoxItem owner, [In] object outer, out object inner);
    }
}

