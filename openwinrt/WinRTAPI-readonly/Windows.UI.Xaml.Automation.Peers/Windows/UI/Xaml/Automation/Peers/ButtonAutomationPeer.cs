namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), Composable(typeof(IButtonAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public class ButtonAutomationPeer : ButtonBaseAutomationPeer, IButtonAutomationPeer, IInvokeProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ButtonAutomationPeer([In] Button owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Invoke();
    }
}

