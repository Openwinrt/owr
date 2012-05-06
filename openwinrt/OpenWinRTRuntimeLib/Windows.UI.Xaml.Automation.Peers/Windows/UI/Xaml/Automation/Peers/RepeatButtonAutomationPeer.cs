namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Composable(typeof(IRepeatButtonAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class RepeatButtonAutomationPeer : ButtonBaseAutomationPeer, IRepeatButtonAutomationPeer, IInvokeProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RepeatButtonAutomationPeer([In] RepeatButton owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Invoke();
    }
}

