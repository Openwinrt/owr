namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Composable(typeof(IThumbAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class ThumbAutomationPeer : FrameworkElementAutomationPeer, IThumbAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ThumbAutomationPeer([In] Thumb owner);
    }
}

