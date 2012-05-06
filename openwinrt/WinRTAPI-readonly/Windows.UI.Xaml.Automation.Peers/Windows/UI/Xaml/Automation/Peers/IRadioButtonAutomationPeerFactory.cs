namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, ExclusiveTo(typeof(RadioButtonAutomationPeer)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4940c4fd, 0x3d88, 0x49ca, 0x8f, 0x31, 0x92, 0x41, 0x87, 0xaf, 11, 0xfe)]
    internal interface IRadioButtonAutomationPeerFactory
    {
        RadioButtonAutomationPeer CreateInstanceWithOwner([In] RadioButton owner, [In] object outer, out object inner);
    }
}

