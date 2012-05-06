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

    [WebHostHidden, Composable(typeof(ICarouselPanelFactory), CompositionType.Public, 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class CarouselPanel : VirtualizingPanel, ICarouselPanel, IScrollInfo, IScrollSnapPointsInfo
    {
        public event Windows.Foundation.EventHandler<object> HorizontalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> VerticalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.HorizontalSnapPointsChanged;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.VerticalSnapPointsChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CarouselPanel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<float> GetIrregularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public float GetRegularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LineDown();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LineLeft();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LineRight();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void LineUp();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect MakeVisible([In] UIElement visual, [In] Rect rectangle);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void MouseWheelDown();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void MouseWheelLeft();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void MouseWheelRight();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void MouseWheelUp();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PageDown();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PageLeft();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PageRight();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PageUp();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetHorizontalOffset([In] double offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetVerticalOffset([In] double offset);

        public bool AreHorizontalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool AreVerticalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanHorizontallyScroll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool CanVerticallyScroll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double ExtentHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ExtentWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollViewer ScrollOwner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ViewportHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ViewportWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollInfo.CanHorizontallyScroll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollInfo.CanVerticallyScroll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.ExtentHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.ExtentWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ScrollViewer Windows.UI.Xaml.Controls.Primitives.IScrollInfo.ScrollOwner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.ViewportHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollInfo.ViewportWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.AreHorizontalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo.AreVerticalSnapPointsRegular { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

