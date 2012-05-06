namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1b5d1336, 0xe61b, 0x4d51, 190, 0x41, 0xfd, 0x8d, 220, 0x55, 0xc5, 0x8b)]
    public interface IScrollInfo
    {
        void LineDown();
        void LineLeft();
        void LineRight();
        void LineUp();
        Rect MakeVisible([In] UIElement visual, [In] Rect rectangle);
        void MouseWheelDown();
        void MouseWheelLeft();
        void MouseWheelRight();
        void MouseWheelUp();
        void PageDown();
        void PageLeft();
        void PageRight();
        void PageUp();
        void SetHorizontalOffset([In] double offset);
        void SetVerticalOffset([In] double offset);

        bool CanHorizontallyScroll { get; [param: In] set; }

        bool CanVerticallyScroll { get; [param: In] set; }

        double ExtentHeight { get; }

        double ExtentWidth { get; }

        double HorizontalOffset { get; }

        ScrollViewer ScrollOwner { get; [param: In] set; }

        double VerticalOffset { get; }

        double ViewportHeight { get; }

        double ViewportWidth { get; }
    }
}

