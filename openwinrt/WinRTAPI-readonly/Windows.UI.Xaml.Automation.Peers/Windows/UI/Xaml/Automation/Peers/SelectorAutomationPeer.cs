namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(ISelectorAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public class SelectorAutomationPeer : ItemsControlAutomationPeer, ISelectorAutomationPeer, ISelectionProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SelectorAutomationPeer([In] Selector owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IRawElementProviderSimple[] GetSelection();

        public bool CanSelectMultiple { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsSelectionRequired { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.ISelectionProvider.CanSelectMultiple { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.ISelectionProvider.IsSelectionRequired { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

