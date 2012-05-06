namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Composable(typeof(IPasswordBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class PasswordBoxAutomationPeer : FrameworkElementAutomationPeer, IPasswordBoxAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordBoxAutomationPeer([In] PasswordBox owner);
    }
}

