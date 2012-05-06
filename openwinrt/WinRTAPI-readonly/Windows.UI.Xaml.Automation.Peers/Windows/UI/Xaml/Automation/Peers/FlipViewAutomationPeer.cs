namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IFlipViewAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000)]
    public class FlipViewAutomationPeer : SelectorAutomationPeer, IFlipViewAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FlipViewAutomationPeer([In] FlipView owner);
    }
}

