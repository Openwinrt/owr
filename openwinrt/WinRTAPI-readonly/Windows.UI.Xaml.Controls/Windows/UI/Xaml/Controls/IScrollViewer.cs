namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), ExclusiveTo(typeof(ScrollViewer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x64e9be00, 0x4dc1, 0x493d, 0xab, 0xe7, 0xcb, 0xd3, 0xc5, 0x77, 0x49, 13)]
    internal interface IScrollViewer
    {
        event Windows.Foundation.EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

        void InvalidateScrollInfo();
        void ScrollToHorizontalOffset([In] double offset);
        void ScrollToVerticalOffset([In] double offset);
        void ZoomToFactor([In] float factor);

        Visibility ComputedHorizontalScrollBarVisibility { get; }

        Visibility ComputedVerticalScrollBarVisibility { get; }

        double ExtentHeight { get; }

        double ExtentWidth { get; }

        double HorizontalOffset { get; }

        ScrollBarVisibility HorizontalScrollBarVisibility { get; [param: In] set; }

        ScrollMode HorizontalScrollMode { get; [param: In] set; }

        SnapPointsAlignment HorizontalSnapPointsAlignment { get; [param: In] set; }

        SnapPointsType HorizontalSnapPointsType { get; [param: In] set; }

        bool IsHorizontalScrollChainingEnabled { get; [param: In] set; }

        bool IsScrollInertiaEnabled { get; [param: In] set; }

        bool IsVerticalScrollChainingEnabled { get; [param: In] set; }

        bool IsZoomChainingEnabled { get; [param: In] set; }

        bool IsZoomInertiaEnabled { get; [param: In] set; }

        float MaxZoomFactor { get; [param: In] set; }

        float MinZoomFactor { get; [param: In] set; }

        double ScrollableHeight { get; }

        double ScrollableWidth { get; }

        double VerticalOffset { get; }

        ScrollBarVisibility VerticalScrollBarVisibility { get; [param: In] set; }

        ScrollMode VerticalScrollMode { get; [param: In] set; }

        SnapPointsAlignment VerticalSnapPointsAlignment { get; [param: In] set; }

        SnapPointsType VerticalSnapPointsType { get; [param: In] set; }

        double ViewportHeight { get; }

        double ViewportWidth { get; }

        float ZoomFactor { get; }

        Windows.UI.Xaml.Controls.ZoomMode ZoomMode { get; [param: In] set; }

        IVector<float> ZoomSnapPoints { get; }

        SnapPointsType ZoomSnapPointsType { get; [param: In] set; }
    }
}

