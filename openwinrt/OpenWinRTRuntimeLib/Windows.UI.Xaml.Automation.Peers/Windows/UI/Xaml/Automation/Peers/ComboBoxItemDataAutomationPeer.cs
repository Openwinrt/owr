namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IComboBoxItemDataAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class ComboBoxItemDataAutomationPeer : SelectorItemAutomationPeer, IComboBoxItemDataAutomationPeer, IScrollItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ComboBoxItemDataAutomationPeer([In] object item, [In] ComboBoxAutomationPeer parent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView();
    }
}

