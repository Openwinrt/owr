namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Composable(typeof(IComboBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000)]
    public class ComboBoxAutomationPeer : SelectorAutomationPeer, IComboBoxAutomationPeer, IValueProvider, IExpandCollapseProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ComboBoxAutomationPeer([In] ComboBox owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Collapse();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Expand();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetValue([In] string value);

        public Windows.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsReadOnly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Automation.ExpandCollapseState Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.IValueProvider.IsReadOnly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Automation.Provider.IValueProvider.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

