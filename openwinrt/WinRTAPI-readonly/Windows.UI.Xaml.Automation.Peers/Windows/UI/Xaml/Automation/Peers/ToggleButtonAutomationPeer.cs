namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Composable(typeof(IToggleButtonAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class ToggleButtonAutomationPeer : ButtonBaseAutomationPeer, IToggleButtonAutomationPeer, IToggleProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToggleButtonAutomationPeer([In] ToggleButton owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Toggle();

        public Windows.UI.Xaml.Automation.ToggleState ToggleState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Automation.ToggleState Windows.UI.Xaml.Automation.Provider.IToggleProvider.ToggleState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

