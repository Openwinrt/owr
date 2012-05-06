namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Static(typeof(IVirtualizingStackPanelStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IVirtualizingStackPanelFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class VirtualizingStackPanel : OrientedVirtualizingPanel, IVirtualizingStackPanel, IVirtualizingStackPanelOverrides
    {
        public event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;

        public event CleanUpVirtualizedItemEventHandler Windows.UI.Xaml.Controls.IVirtualizingStackPanel.CleanUpVirtualizedItemEvent;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VirtualizingStackPanel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsVirtualizing([In] DependencyObject o);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static VirtualizationMode GetVirtualizationMode([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnCleanUpVirtualizedItem([In] CleanUpVirtualizedItemEventArgs e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetVirtualizationMode([In] DependencyObject element, [In] VirtualizationMode value);

        public bool AreScrollSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsVirtualizingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Orientation Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OrientationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty VirtualizationModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IVirtualizingStackPanel.AreScrollSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Controls.Orientation Windows.UI.Xaml.Controls.IVirtualizingStackPanel.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

