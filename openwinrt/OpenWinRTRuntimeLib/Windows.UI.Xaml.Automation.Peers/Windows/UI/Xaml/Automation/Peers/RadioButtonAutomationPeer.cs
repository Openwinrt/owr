namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IRadioButtonAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both)]
    public class RadioButtonAutomationPeer : ToggleButtonAutomationPeer, IRadioButtonAutomationPeer, ISelectionItemProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RadioButtonAutomationPeer([In] RadioButton owner);
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

