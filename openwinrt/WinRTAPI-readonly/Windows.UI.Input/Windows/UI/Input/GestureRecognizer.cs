namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class GestureRecognizer : IGestureRecognizer
    {
        public event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;

        public event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;

        public event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;

        public event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;

        public event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;

        public event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;

        public event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;

        public event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;

        public event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;

        public event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> Windows.UI.Input.IGestureRecognizer.CrossSliding;

        public event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Windows.UI.Input.IGestureRecognizer.Dragging;

        public event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Windows.UI.Input.IGestureRecognizer.Holding;

        public event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> Windows.UI.Input.IGestureRecognizer.ManipulationCompleted;

        public event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> Windows.UI.Input.IGestureRecognizer.ManipulationInertiaStarting;

        public event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> Windows.UI.Input.IGestureRecognizer.ManipulationStarted;

        public event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> Windows.UI.Input.IGestureRecognizer.ManipulationUpdated;

        public event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> Windows.UI.Input.IGestureRecognizer.RightTapped;

        public event TypedEventHandler<GestureRecognizer, TappedEventArgs> Windows.UI.Input.IGestureRecognizer.Tapped;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GestureRecognizer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool CanBeDoubleTap([In] PointerPoint value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CompleteGesture();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessDownEvent([In] PointerPoint value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessInertia();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessMouseWheelEvent([In] PointerPoint value, [In] bool isShiftKeyDown, [In] bool isControlKeyDown);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessMoveEvents([In] IVector<PointerPoint> value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ProcessUpEvent([In] PointerPoint value);

        public bool AutoProcessInertia { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool CrossSlideHorizontally { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Input.CrossSlideThresholds CrossSlideThresholds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Input.GestureSettings GestureSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaExpansion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaExpansionDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaRotationAngle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaRotationDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaTranslationDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float InertiaTranslationDisplacement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsInertial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Input.MouseWheelParameters MouseWheelParameters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point PivotCenter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float PivotRadius { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool ShowGestureFeedback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Input.IGestureRecognizer.AutoProcessInertia { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Input.IGestureRecognizer.CrossSlideHorizontally { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Input.CrossSlideThresholds Windows.UI.Input.IGestureRecognizer.CrossSlideThresholds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Input.GestureSettings Windows.UI.Input.IGestureRecognizer.GestureSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaExpansion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaExpansionDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaRotationAngle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaRotationDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaTranslationDeceleration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.InertiaTranslationDisplacement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Input.IGestureRecognizer.IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Input.IGestureRecognizer.IsInertial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Input.MouseWheelParameters Windows.UI.Input.IGestureRecognizer.MouseWheelParameters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IGestureRecognizer.PivotCenter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public float Windows.UI.Input.IGestureRecognizer.PivotRadius { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Input.IGestureRecognizer.ShowGestureFeedback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

