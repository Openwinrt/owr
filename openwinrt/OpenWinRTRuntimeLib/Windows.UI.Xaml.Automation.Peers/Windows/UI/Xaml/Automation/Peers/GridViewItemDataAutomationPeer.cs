namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [Composable(typeof(IGridViewItemDataAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class GridViewItemDataAutomationPeer : SelectorItemAutomationPeer, IGridViewItemDataAutomationPeer, IScrollItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GridViewItemDataAutomationPeer([In] object item, [In] GridViewAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView();
    }
}

