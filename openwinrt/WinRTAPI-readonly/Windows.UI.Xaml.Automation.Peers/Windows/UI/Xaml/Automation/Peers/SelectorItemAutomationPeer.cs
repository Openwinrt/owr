namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [Composable(typeof(ISelectorItemAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class SelectorItemAutomationPeer : ItemAutomationPeer, ISelectorItemAutomationPeer, ISelectionItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SelectorItemAutomationPeer([In] object item, [In] SelectorAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddToSelection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveFromSelection();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Select();

        public bool IsSelected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IRawElementProviderSimple SelectionContainer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider.IsSelected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IRawElementProviderSimple Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider.SelectionContainer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

