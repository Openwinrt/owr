namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x1f0c067, 0x966b, 0x4130, 0xb8, 0x72, 70, 0x9e, 0x42, 0xbd, 0x4a, 0x7f), Version(0x6020000), ExclusiveTo(typeof(TextBoxAutomationPeer)), WebHostHidden]
    internal interface ITextBoxAutomationPeerFactory
    {
        TextBoxAutomationPeer CreateInstanceWithOwner([In] TextBox owner, [In] object outer, out object inner);
    }
}

