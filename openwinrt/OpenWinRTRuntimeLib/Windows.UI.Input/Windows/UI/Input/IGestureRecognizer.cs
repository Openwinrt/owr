namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb47a37bf, 0x3d6b, 0x4f88, 0x83, 0xe8, 0x6d, 0xcb, 0x40, 0x12, 0xff, 0xb0), Version(0x6020000), ExclusiveTo(typeof(GestureRecognizer))]
    internal interface IGestureRecognizer
    {
        event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;

        event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;

        event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;

        event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;

        event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;

        event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;

        event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;

        event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;

        event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;

        bool CanBeDoubleTap([In] PointerPoint value);
        void CompleteGesture();
        void ProcessDownEvent([In] PointerPoint value);
        void ProcessInertia();
        void ProcessMouseWheelEvent([In] PointerPoint value, [In] bool isShiftKeyDown, [In] bool isControlKeyDown);
        void ProcessMoveEvents([In] IVector<PointerPoint> value);
        void ProcessUpEvent([In] PointerPoint value);

        bool AutoProcessInertia { get; [param: In] set; }

        bool CrossSlideHorizontally { get; [param: In] set; }

        Windows.UI.Input.CrossSlideThresholds CrossSlideThresholds { get; [param: In] set; }

        Windows.UI.Input.GestureSettings GestureSettings { get; [param: In] set; }

        float InertiaExpansion { get; [param: In] set; }

        float InertiaExpansionDeceleration { get; [param: In] set; }

        float InertiaRotationAngle { get; [param: In] set; }

        float InertiaRotationDeceleration { get; [param: In] set; }

        float InertiaTranslationDeceleration { get; [param: In] set; }

        float InertiaTranslationDisplacement { get; [param: In] set; }

        bool IsActive { get; }

        bool IsInertial { get; }

        Windows.UI.Input.MouseWheelParameters MouseWheelParameters { get; }

        Point PivotCenter { get; [param: In] set; }

        float PivotRadius { get; [param: In] set; }

        bool ShowGestureFeedback { get; [param: In] set; }
    }
}

