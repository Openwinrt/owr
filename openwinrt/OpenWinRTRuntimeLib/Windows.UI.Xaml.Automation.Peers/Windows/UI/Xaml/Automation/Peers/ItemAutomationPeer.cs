namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Composable(typeof(IItemAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class ItemAutomationPeer : AutomationPeer, IItemAutomationPeer, IVirtualizedItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemAutomationPeer([In] object item, [In] Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Realize();

        public object Item { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer ItemsControlAutomationPeer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.Automation.Peers.IItemAutomationPeer.Item { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer Windows.UI.Xaml.Automation.Peers.IItemAutomationPeer.ItemsControlAutomationPeer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

