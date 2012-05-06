namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Composable(typeof(IItemsControlAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class ItemsControlAutomationPeer : FrameworkElementAutomationPeer, IItemsControlAutomationPeer, IItemContainerProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemsControlAutomationPeer([In] ItemsControl owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IRawElementProviderSimple FindItemByProperty([In] IRawElementProviderSimple startAfter, [In] AutomationProperty property, [In] object value);
    }
}

