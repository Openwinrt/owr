namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(IRangeBaseAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class RangeBaseAutomationPeer : FrameworkElementAutomationPeer, IRangeBaseAutomationPeer, IRangeValueProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RangeBaseAutomationPeer([In] RangeBase owner);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetValue([In] double value);

        public bool IsReadOnly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double LargeChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Maximum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Minimum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double SmallChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.IsReadOnly { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.LargeChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.Maximum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.Minimum { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.SmallChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Automation.Provider.IRangeValueProvider.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

