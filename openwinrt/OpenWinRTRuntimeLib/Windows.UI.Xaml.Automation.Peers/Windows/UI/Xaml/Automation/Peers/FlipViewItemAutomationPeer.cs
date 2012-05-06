namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IFlipViewItemAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class FlipViewItemAutomationPeer : FrameworkElementAutomationPeer, IFlipViewItemAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FlipViewItemAutomationPeer([In] FlipViewItem owner);
    }
}

