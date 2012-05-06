namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IHyperlinkButtonAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public class HyperlinkButtonAutomationPeer : ButtonBaseAutomationPeer, IHyperlinkButtonAutomationPeer, IInvokeProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public HyperlinkButtonAutomationPeer([In] HyperlinkButton owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Invoke();
    }
}

