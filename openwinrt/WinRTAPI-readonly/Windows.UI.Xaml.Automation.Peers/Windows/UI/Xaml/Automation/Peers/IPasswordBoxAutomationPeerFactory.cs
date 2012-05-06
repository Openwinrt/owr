namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(PasswordBoxAutomationPeer)), Windows.Foundation.Metadata.Guid(0xac3d7ede, 0xdca4, 0x481c, 0xb5, 0x20, 0x4a, 0x9b, 0x3f, 0x3b, 0x17, 0x9c), WebHostHidden, Version(0x6020000)]
    internal interface IPasswordBoxAutomationPeerFactory
    {
        PasswordBoxAutomationPeer CreateInstanceWithOwner([In] PasswordBox owner, [In] object outer, out object inner);
    }
}

