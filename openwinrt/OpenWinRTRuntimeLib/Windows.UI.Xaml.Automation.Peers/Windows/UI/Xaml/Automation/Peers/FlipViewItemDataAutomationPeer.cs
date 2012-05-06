namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IFlipViewItemDataAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden]
    public class FlipViewItemDataAutomationPeer : SelectorItemAutomationPeer, IFlipViewItemDataAutomationPeer, IScrollItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FlipViewItemDataAutomationPeer([In] object item, [In] FlipViewAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView();
    }
}

