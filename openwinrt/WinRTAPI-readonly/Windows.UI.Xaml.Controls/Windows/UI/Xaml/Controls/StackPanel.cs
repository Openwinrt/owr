namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IStackPanelStatics), 0x6020000), Composable(typeof(IStackPanelFactory), CompositionType.Public, 0x6020000)]
    public class StackPanel : Panel, IStackPanel, IScrollSnapPointsInfo
    {
        public event Windows.Foundation.EventHandler<object> HorizontalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> VerticalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.HorizontalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.VerticalSnapPointsChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StackPanel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<float> GetIrregularSnapPoints([In] Windows.UI.Xaml.Controls.Orientation orientation, [In] SnapPointsAlignment alignment);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public float GetRegularSnapPoints([In] Windows.UI.Xaml.Controls.Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);

        public bool AreHorizontalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool AreScrollSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool AreVerticalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Orientation Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OrientationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IStackPanel.AreScrollSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Controls.Orientation Windows.UI.Xaml.Controls.IStackPanel.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.AreHorizontalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.AreVerticalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

