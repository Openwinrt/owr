namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Composable(typeof(IToggleSwitchAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class ToggleSwitchAutomationPeer : FrameworkElementAutomationPeer, IToggleSwitchAutomationPeer, IToggleProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToggleSwitchAutomationPeer([In] ToggleSwitch owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Toggle();

        public Windows.UI.Xaml.Automation.ToggleState ToggleState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Automation.ToggleState Windows.UI.Xaml.Automation.Provider.IToggleProvider.ToggleState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

