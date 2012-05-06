namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IFrameworkElementAutomationPeerFactory), CompositionType.Public, 0x6020000), Static(typeof(IFrameworkElementAutomationPeerStatics), 0x6020000)]
    public class FrameworkElementAutomationPeer : AutomationPeer, IFrameworkElementAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FrameworkElementAutomationPeer([In] FrameworkElement owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static AutomationPeer CreatePeerForElement([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static AutomationPeer FromElement([In] UIElement element);

        public UIElement Owner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.Automation.Peers.IFrameworkElementAutomationPeer.Owner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

