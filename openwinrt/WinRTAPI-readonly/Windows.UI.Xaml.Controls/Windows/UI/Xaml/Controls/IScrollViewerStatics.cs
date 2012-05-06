namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x33d1299d, 0x8d6e, 0x4290, 0xbf, 0x22, 0x90, 0x5c, 0xcc, 0xd0, 0x4d, 0x31), ExclusiveTo(typeof(ScrollViewer)), WebHostHidden]
    internal interface IScrollViewerStatics
    {
        ScrollBarVisibility GetHorizontalScrollBarVisibility([In] DependencyObject element);
        ScrollMode GetHorizontalScrollMode([In] DependencyObject element);
        bool GetIsHorizontalScrollChainingEnabled([In] DependencyObject element);
        bool GetIsScrollInertiaEnabled([In] DependencyObject element);
        bool GetIsVerticalScrollChainingEnabled([In] DependencyObject element);
        bool GetIsZoomChainingEnabled([In] DependencyObject element);
        bool GetIsZoomInertiaEnabled([In] DependencyObject element);
        ScrollBarVisibility GetVerticalScrollBarVisibility([In] DependencyObject element);
        ScrollMode GetVerticalScrollMode([In] DependencyObject element);
        ZoomMode GetZoomMode([In] DependencyObject element);
        void SetHorizontalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility horizontalScrollBarVisibility);
        void SetHorizontalScrollMode([In] DependencyObject element, [In] ScrollMode horizontalScrollMode);
        void SetIsHorizontalScrollChainingEnabled([In] DependencyObject element, [In] bool isHorizontalScrollChainingEnabled);
        void SetIsScrollInertiaEnabled([In] DependencyObject element, [In] bool isScrollInertiaEnabled);
        void SetIsVerticalScrollChainingEnabled([In] DependencyObject element, [In] bool isVerticalScrollChainingEnabled);
        void SetIsZoomChainingEnabled([In] DependencyObject element, [In] bool isZoomChainingEnabled);
        void SetIsZoomInertiaEnabled([In] DependencyObject element, [In] bool isZoomInertiaEnabled);
        void SetVerticalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility verticalScrollBarVisibility);
        void SetVerticalScrollMode([In] DependencyObject element, [In] ScrollMode verticalScrollMode);
        void SetZoomMode([In] DependencyObject element, [In] ZoomMode zoomMode);

        DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { get; }

        DependencyProperty ComputedVerticalScrollBarVisibilityProperty { get; }

        DependencyProperty ExtentHeightProperty { get; }

        DependencyProperty ExtentWidthProperty { get; }

        DependencyProperty HorizontalOffsetProperty { get; }

        DependencyProperty HorizontalScrollBarVisibilityProperty { get; }

        DependencyProperty HorizontalScrollModeProperty { get; }

        DependencyProperty HorizontalSnapPointsAlignmentProperty { get; }

        DependencyProperty HorizontalSnapPointsTypeProperty { get; }

        DependencyProperty IsHorizontalScrollChainingEnabledProperty { get; }

        DependencyProperty IsScrollInertiaEnabledProperty { get; }

        DependencyProperty IsVerticalScrollChainingEnabledProperty { get; }

        DependencyProperty IsZoomChainingEnabledProperty { get; }

        DependencyProperty IsZoomInertiaEnabledProperty { get; }

        DependencyProperty MaxZoomFactorProperty { get; }

        DependencyProperty MinZoomFactorProperty { get; }

        DependencyProperty ScrollableHeightProperty { get; }

        DependencyProperty ScrollableWidthProperty { get; }

        DependencyProperty VerticalOffsetProperty { get; }

        DependencyProperty VerticalScrollBarVisibilityProperty { get; }

        DependencyProperty VerticalScrollModeProperty { get; }

        DependencyProperty VerticalSnapPointsAlignmentProperty { get; }

        DependencyProperty VerticalSnapPointsTypeProperty { get; }

        DependencyProperty ViewportHeightProperty { get; }

        DependencyProperty ViewportWidthProperty { get; }

        DependencyProperty ZoomFactorProperty { get; }

        DependencyProperty ZoomModeProperty { get; }

        DependencyProperty ZoomSnapPointsProperty { get; }

        DependencyProperty ZoomSnapPointsTypeProperty { get; }
    }
}

