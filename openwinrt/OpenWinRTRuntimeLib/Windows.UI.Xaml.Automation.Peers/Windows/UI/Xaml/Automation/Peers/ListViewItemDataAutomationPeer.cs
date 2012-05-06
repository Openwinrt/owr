namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [WebHostHidden, Version(0x6020000), Composable(typeof(IListViewItemDataAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class ListViewItemDataAutomationPeer : SelectorItemAutomationPeer, IListViewItemDataAutomationPeer, IScrollItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListViewItemDataAutomationPeer([In] object item, [In] ListViewBaseAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView();
    }
}

