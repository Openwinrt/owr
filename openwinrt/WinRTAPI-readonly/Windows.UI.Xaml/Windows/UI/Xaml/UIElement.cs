namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Peers;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [Composable(typeof(IUIElementFactory), CompositionType.Protected, 0x6020000), Static(typeof(IUIElementStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000)]
    public class UIElement : DependencyObject, IUIElement, IUIElementOverrides
    {
        public event DoubleTappedEventHandler DoubleTapped;

        public event DragEventHandler DragEnter;

        public event DragEventHandler DragLeave;

        public event DragEventHandler DragOver;

        public event DragEventHandler Drop;

        public event RoutedEventHandler GotFocus;

        public event HoldingEventHandler Holding;

        public event KeyEventHandler KeyDown;

        public event KeyEventHandler KeyUp;

        public event RoutedEventHandler LostFocus;

        public event ManipulationCompletedEventHandler ManipulationCompleted;

        public event ManipulationDeltaEventHandler ManipulationDelta;

        public event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;

        public event ManipulationStartedEventHandler ManipulationStarted;

        public event ManipulationStartingEventHandler ManipulationStarting;

        public event PointerEventHandler PointerCanceled;

        public event PointerEventHandler PointerCaptureLost;

        public event PointerEventHandler PointerEntered;

        public event PointerEventHandler PointerExited;

        public event PointerEventHandler PointerMoved;

        public event PointerEventHandler PointerPressed;

        public event PointerEventHandler PointerReleased;

        public event PointerEventHandler PointerWheelChanged;

        public event RightTappedEventHandler RightTapped;

        public event TappedEventHandler Tapped;

        public event DoubleTappedEventHandler Windows.UI.Xaml.IUIElement.DoubleTapped;

        public event DragEventHandler Windows.UI.Xaml.IUIElement.DragEnter;

        public event DragEventHandler Windows.UI.Xaml.IUIElement.DragLeave;

        public event DragEventHandler Windows.UI.Xaml.IUIElement.DragOver;

        public event DragEventHandler Windows.UI.Xaml.IUIElement.Drop;

        public event RoutedEventHandler Windows.UI.Xaml.IUIElement.GotFocus;

        public event HoldingEventHandler Windows.UI.Xaml.IUIElement.Holding;

        public event KeyEventHandler Windows.UI.Xaml.IUIElement.KeyDown;

        public event KeyEventHandler Windows.UI.Xaml.IUIElement.KeyUp;

        public event RoutedEventHandler Windows.UI.Xaml.IUIElement.LostFocus;

        public event ManipulationCompletedEventHandler Windows.UI.Xaml.IUIElement.ManipulationCompleted;

        public event ManipulationDeltaEventHandler Windows.UI.Xaml.IUIElement.ManipulationDelta;

        public event ManipulationInertiaStartingEventHandler Windows.UI.Xaml.IUIElement.ManipulationInertiaStarting;

        public event ManipulationStartedEventHandler Windows.UI.Xaml.IUIElement.ManipulationStarted;

        public event ManipulationStartingEventHandler Windows.UI.Xaml.IUIElement.ManipulationStarting;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerCanceled;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerCaptureLost;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerEntered;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerExited;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerMoved;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerPressed;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerReleased;

        public event PointerEventHandler Windows.UI.Xaml.IUIElement.PointerWheelChanged;

        public event RightTappedEventHandler Windows.UI.Xaml.IUIElement.RightTapped;

        public event TappedEventHandler Windows.UI.Xaml.IUIElement.Tapped;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddHandler([In] RoutedEvent routedEvent, [In] object handler, [In] bool handledEventsToo);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Arrange([In] Rect finalRect);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool CapturePointer([In] Pointer value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual IIterable<IIterable<Point>> FindSubElementsForTouchTargeting([In] Point point, [In] Rect boundingRect);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvalidateArrange();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvalidateMeasure();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Measure([In] Size availableSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual AutomationPeer OnCreateAutomationPeer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnDisconnectVisualChildren();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReleasePointerCapture([In] Pointer value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReleasePointerCaptures();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveHandler([In] RoutedEvent routedEvent, [In] object handler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GeneralTransform TransformToVisual([In] UIElement visual);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UpdateLayout();

        public bool AllowDrop { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AllowDropProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.CacheMode CacheMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CacheModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RectangleGeometry Clip { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ClipProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size DesiredSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent DoubleTappedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent DragEnterEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent DragLeaveEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent DragOverEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent DropEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent HoldingEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsDoubleTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsDoubleTapEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsHitTestVisible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsHitTestVisibleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsHoldingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsHoldingEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsRightTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsRightTapEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsTapEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent KeyDownEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent KeyUpEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent ManipulationCompletedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent ManipulationDeltaEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent ManipulationInertiaStartingEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationModes ManipulationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ManipulationModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent ManipulationStartedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent ManipulationStartingEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Opacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OpacityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerCanceledEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerCaptureLostEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<Pointer> PointerCaptures { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PointerCapturesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerEnteredEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerExitedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerMovedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerPressedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerReleasedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent PointerWheelChangedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Projection Projection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ProjectionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size RenderSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Transform RenderTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point RenderTransformOrigin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty RenderTransformOriginProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty RenderTransformProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent RightTappedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static RoutedEvent TappedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransitionCollection Transitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TransitionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool UseLayoutRounding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty UseLayoutRoundingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Visibility Visibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VisibilityProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.IUIElement.AllowDrop { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.CacheMode Windows.UI.Xaml.IUIElement.CacheMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public RectangleGeometry Windows.UI.Xaml.IUIElement.Clip { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size Windows.UI.Xaml.IUIElement.DesiredSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.IUIElement.IsDoubleTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IUIElement.IsHitTestVisible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IUIElement.IsHoldingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IUIElement.IsRightTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IUIElement.IsTapEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ManipulationModes Windows.UI.Xaml.IUIElement.ManipulationMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IUIElement.Opacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<Pointer> Windows.UI.Xaml.IUIElement.PointerCaptures { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Projection Windows.UI.Xaml.IUIElement.Projection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size Windows.UI.Xaml.IUIElement.RenderSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Transform Windows.UI.Xaml.IUIElement.RenderTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Xaml.IUIElement.RenderTransformOrigin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TransitionCollection Windows.UI.Xaml.IUIElement.Transitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IUIElement.UseLayoutRounding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Visibility Windows.UI.Xaml.IUIElement.Visibility { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

