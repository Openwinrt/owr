namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0xb75c775d, 0xeb8f, 0x44ef, 0xa2, 0x7c, 0xe2, 0x6a, 0xc7, 0xde, 0x83, 0x33), Version(0x6020000), ExclusiveTo(typeof(CheckBoxAutomationPeer)), WebHostHidden]
    internal interface ICheckBoxAutomationPeerFactory
    {
        CheckBoxAutomationPeer CreateInstanceWithOwner([In] CheckBox owner, [In] object outer, out object inner);
    }
}

