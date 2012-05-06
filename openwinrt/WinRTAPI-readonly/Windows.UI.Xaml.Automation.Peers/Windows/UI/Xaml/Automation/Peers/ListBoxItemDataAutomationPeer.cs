namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both), Composable(typeof(IListBoxItemDataAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class ListBoxItemDataAutomationPeer : SelectorItemAutomationPeer, IListBoxItemDataAutomationPeer, IScrollItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListBoxItemDataAutomationPeer([In] object item, [In] ListBoxAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView();
    }
}

