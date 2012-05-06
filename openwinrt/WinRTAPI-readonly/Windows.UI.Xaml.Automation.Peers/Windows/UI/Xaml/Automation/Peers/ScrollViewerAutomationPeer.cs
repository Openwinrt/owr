namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(IScrollViewerAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class ScrollViewerAutomationPeer : FrameworkElementAutomationPeer, IScrollViewerAutomationPeer, IScrollProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScrollViewerAutomationPeer([In] ScrollViewer owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Scroll([In] ScrollAmount horizontalAmount, [In] ScrollAmount verticalAmount);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetScrollPercent([In] double horizontalPercent, [In] double verticalPercent);

        public bool HorizontallyScrollable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double HorizontalScrollPercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double HorizontalViewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool VerticallyScrollable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalScrollPercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalViewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontallyScrollable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontalScrollPercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IScrollProvider.HorizontalViewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticallyScrollable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticalScrollPercent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IScrollProvider.VerticalViewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

