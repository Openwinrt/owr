namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x676d0be9, 0xb65c, 0x41c6, 0xba, 0x40, 0x58, 0xcf, 0x87, 0xf2, 1, 0xc1), ExclusiveTo(typeof(UIElement))]
    internal interface IUIElement
    {
        event DoubleTappedEventHandler DoubleTapped;

        event DragEventHandler DragEnter;

        event DragEventHandler DragLeave;

        event DragEventHandler DragOver;

        event DragEventHandler Drop;

        event RoutedEventHandler GotFocus;

        event HoldingEventHandler Holding;

        event KeyEventHandler KeyDown;

        event KeyEventHandler KeyUp;

        event RoutedEventHandler LostFocus;

        event ManipulationCompletedEventHandler ManipulationCompleted;

        event ManipulationDeltaEventHandler ManipulationDelta;

        event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;

        event ManipulationStartedEventHandler ManipulationStarted;

        event ManipulationStartingEventHandler ManipulationStarting;

        event PointerEventHandler PointerCanceled;

        event PointerEventHandler PointerCaptureLost;

        event PointerEventHandler PointerEntered;

        event PointerEventHandler PointerExited;

        event PointerEventHandler PointerMoved;

        event PointerEventHandler PointerPressed;

        event PointerEventHandler PointerReleased;

        event PointerEventHandler PointerWheelChanged;

        event RightTappedEventHandler RightTapped;

        event TappedEventHandler Tapped;

        void AddHandler([In] RoutedEvent routedEvent, [In] object handler, [In] bool handledEventsToo);
        void Arrange([In] Rect finalRect);
        bool CapturePointer([In] Pointer value);
        void InvalidateArrange();
        void InvalidateMeasure();
        void Measure([In] Size availableSize);
        void ReleasePointerCapture([In] Pointer value);
        void ReleasePointerCaptures();
        void RemoveHandler([In] RoutedEvent routedEvent, [In] object handler);
        GeneralTransform TransformToVisual([In] UIElement visual);
        void UpdateLayout();

        bool AllowDrop { get; [param: In] set; }

        Windows.UI.Xaml.Media.CacheMode CacheMode { get; [param: In] set; }

        RectangleGeometry Clip { get; [param: In] set; }

        Size DesiredSize { get; }

        bool IsDoubleTapEnabled { get; [param: In] set; }

        bool IsHitTestVisible { get; [param: In] set; }

        bool IsHoldingEnabled { get; [param: In] set; }

        bool IsRightTapEnabled { get; [param: In] set; }

        bool IsTapEnabled { get; [param: In] set; }

        ManipulationModes ManipulationMode { get; [param: In] set; }

        double Opacity { get; [param: In] set; }

        IVectorView<Pointer> PointerCaptures { get; }

        Windows.UI.Xaml.Media.Projection Projection { get; [param: In] set; }

        Size RenderSize { get; }

        Transform RenderTransform { get; [param: In] set; }

        Point RenderTransformOrigin { get; [param: In] set; }

        TransitionCollection Transitions { get; [param: In] set; }

        bool UseLayoutRounding { get; [param: In] set; }

        Windows.UI.Xaml.Visibility Visibility { get; [param: In] set; }
    }
}

