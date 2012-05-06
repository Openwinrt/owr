namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IRichEditBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public class RichEditBoxAutomationPeer : FrameworkElementAutomationPeer, IRichEditBoxAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RichEditBoxAutomationPeer([In] RichEditBox owner);
    }
}

