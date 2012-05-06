namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x58d3573b, 0xf52c, 0x45be, 0x98, 0x8b, 0xa5, 0x86, 0x95, 100, 0x87, 60), ExclusiveTo(typeof(UIElement))]
    internal interface IUIElementStatics
    {
        DependencyProperty AllowDropProperty { get; }

        DependencyProperty CacheModeProperty { get; }

        DependencyProperty ClipProperty { get; }

        RoutedEvent DoubleTappedEvent { get; }

        RoutedEvent DragEnterEvent { get; }

        RoutedEvent DragLeaveEvent { get; }

        RoutedEvent DragOverEvent { get; }

        RoutedEvent DropEvent { get; }

        RoutedEvent HoldingEvent { get; }

        DependencyProperty IsDoubleTapEnabledProperty { get; }

        DependencyProperty IsHitTestVisibleProperty { get; }

        DependencyProperty IsHoldingEnabledProperty { get; }

        DependencyProperty IsRightTapEnabledProperty { get; }

        DependencyProperty IsTapEnabledProperty { get; }

        RoutedEvent KeyDownEvent { get; }

        RoutedEvent KeyUpEvent { get; }

        RoutedEvent ManipulationCompletedEvent { get; }

        RoutedEvent ManipulationDeltaEvent { get; }

        RoutedEvent ManipulationInertiaStartingEvent { get; }

        DependencyProperty ManipulationModeProperty { get; }

        RoutedEvent ManipulationStartedEvent { get; }

        RoutedEvent ManipulationStartingEvent { get; }

        DependencyProperty OpacityProperty { get; }

        RoutedEvent PointerCanceledEvent { get; }

        RoutedEvent PointerCaptureLostEvent { get; }

        DependencyProperty PointerCapturesProperty { get; }

        RoutedEvent PointerEnteredEvent { get; }

        RoutedEvent PointerExitedEvent { get; }

        RoutedEvent PointerMovedEvent { get; }

        RoutedEvent PointerPressedEvent { get; }

        RoutedEvent PointerReleasedEvent { get; }

        RoutedEvent PointerWheelChangedEvent { get; }

        DependencyProperty ProjectionProperty { get; }

        DependencyProperty RenderTransformOriginProperty { get; }

        DependencyProperty RenderTransformProperty { get; }

        RoutedEvent RightTappedEvent { get; }

        RoutedEvent TappedEvent { get; }

        DependencyProperty TransitionsProperty { get; }

        DependencyProperty UseLayoutRoundingProperty { get; }

        DependencyProperty VisibilityProperty { get; }
    }
}

