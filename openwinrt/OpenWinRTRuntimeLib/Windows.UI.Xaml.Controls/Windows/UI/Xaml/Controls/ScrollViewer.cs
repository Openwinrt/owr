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

    [Activatable(0x6020000), Static(typeof(IScrollViewerStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ScrollViewer : ContentControl, IScrollViewer
    {
        public event Windows.Foundation.EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

        public event Windows.Foundation.EventHandler<ScrollViewerViewChangedEventArgs> Windows.UI.Xaml.Controls.IScrollViewer.ViewChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScrollViewer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ScrollBarVisibility GetHorizontalScrollBarVisibility([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ScrollMode GetHorizontalScrollMode([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsHorizontalScrollChainingEnabled([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsScrollInertiaEnabled([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsVerticalScrollChainingEnabled([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsZoomChainingEnabled([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsZoomInertiaEnabled([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ScrollBarVisibility GetVerticalScrollBarVisibility([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ScrollMode GetVerticalScrollMode([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Windows.UI.Xaml.Controls.ZoomMode GetZoomMode([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvalidateScrollInfo();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollToHorizontalOffset([In] double offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollToVerticalOffset([In] double offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHorizontalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility horizontalScrollBarVisibility);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHorizontalScrollMode([In] DependencyObject element, [In] ScrollMode horizontalScrollMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsHorizontalScrollChainingEnabled([In] DependencyObject element, [In] bool isHorizontalScrollChainingEnabled);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsScrollInertiaEnabled([In] DependencyObject element, [In] bool isScrollInertiaEnabled);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsVerticalScrollChainingEnabled([In] DependencyObject element, [In] bool isVerticalScrollChainingEnabled);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsZoomChainingEnabled([In] DependencyObject element, [In] bool isZoomChainingEnabled);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsZoomInertiaEnabled([In] DependencyObject element, [In] bool isZoomInertiaEnabled);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetVerticalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility verticalScrollBarVisibility);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetVerticalScrollMode([In] DependencyObject element, [In] ScrollMode verticalScrollMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetZoomMode([In] DependencyObject element, [In] Windows.UI.Xaml.Controls.ZoomMode zoomMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ZoomToFactor([In] float factor);

        public Visibility ComputedHorizontalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Visibility ComputedVerticalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ComputedVerticalScrollBarVisibilityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ExtentHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ExtentHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ExtentWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ExtentWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty HorizontalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollBarVisibility HorizontalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalScrollBarVisibilityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollMode HorizontalScrollMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalScrollModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsAlignment HorizontalSnapPointsAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalSnapPointsAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsType HorizontalSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalSnapPointsTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsHorizontalScrollChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsHorizontalScrollChainingEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsScrollInertiaEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsScrollInertiaEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsVerticalScrollChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsVerticalScrollChainingEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsZoomChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsZoomChainingEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsZoomInertiaEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsZoomInertiaEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float MaxZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxZoomFactorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float MinZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinZoomFactorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ScrollableHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ScrollableHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ScrollableWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ScrollableWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty VerticalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollBarVisibility VerticalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalScrollBarVisibilityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollMode VerticalScrollMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalScrollModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsAlignment VerticalSnapPointsAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalSnapPointsAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsType VerticalSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalSnapPointsTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ViewportHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ViewportHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ViewportWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ViewportWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Visibility Windows.UI.Xaml.Controls.IScrollViewer.ComputedHorizontalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Visibility Windows.UI.Xaml.Controls.IScrollViewer.ComputedVerticalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ExtentHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ExtentWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollBarVisibility Windows.UI.Xaml.Controls.IScrollViewer.HorizontalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ScrollMode Windows.UI.Xaml.Controls.IScrollViewer.HorizontalScrollMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SnapPointsAlignment Windows.UI.Xaml.Controls.IScrollViewer.HorizontalSnapPointsAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SnapPointsType Windows.UI.Xaml.Controls.IScrollViewer.HorizontalSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IScrollViewer.IsHorizontalScrollChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IScrollViewer.IsScrollInertiaEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IScrollViewer.IsVerticalScrollChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IScrollViewer.IsZoomChainingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IScrollViewer.IsZoomInertiaEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Xaml.Controls.IScrollViewer.MaxZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Xaml.Controls.IScrollViewer.MinZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ScrollableHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ScrollableWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollBarVisibility Windows.UI.Xaml.Controls.IScrollViewer.VerticalScrollBarVisibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ScrollMode Windows.UI.Xaml.Controls.IScrollViewer.VerticalScrollMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SnapPointsAlignment Windows.UI.Xaml.Controls.IScrollViewer.VerticalSnapPointsAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SnapPointsType Windows.UI.Xaml.Controls.IScrollViewer.VerticalSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ViewportHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IScrollViewer.ViewportWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Xaml.Controls.IScrollViewer.ZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.ZoomMode Windows.UI.Xaml.Controls.IScrollViewer.ZoomMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<float> Windows.UI.Xaml.Controls.IScrollViewer.ZoomSnapPoints { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsType Windows.UI.Xaml.Controls.IScrollViewer.ZoomSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float ZoomFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ZoomFactorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.ZoomMode ZoomMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ZoomModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<float> ZoomSnapPoints { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ZoomSnapPointsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SnapPointsType ZoomSnapPointsType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ZoomSnapPointsTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

