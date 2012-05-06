namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IButtonBaseAutomationPeerFactory), CompositionType.Protected, 0x6020000), WebHostHidden]
    public class ButtonBaseAutomationPeer : FrameworkElementAutomationPeer, IButtonBaseAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected ButtonBaseAutomationPeer([In] ButtonBase owner);
    }
}

