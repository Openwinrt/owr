namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Input;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa09691df, 0x9824, 0x41fe, 0xb5, 0x30, 0xb0, 0xd8, 0x99, 14, 100, 0xc1), ExclusiveTo(typeof(Control)), WebHostHidden]
    internal interface IControlOverrides
    {
        void OnDoubleTapped([In] DoubleTappedRoutedEventArgs e);
        void OnDragEnter([In] DragEventArgs e);
        void OnDragLeave([In] DragEventArgs e);
        void OnDragOver([In] DragEventArgs e);
        void OnDrop([In] DragEventArgs e);
        void OnGotFocus([In] RoutedEventArgs e);
        void OnHolding([In] HoldingRoutedEventArgs e);
        void OnKeyDown([In] KeyEventArgs e);
        void OnKeyUp([In] KeyEventArgs e);
        void OnLostFocus([In] RoutedEventArgs e);
        void OnManipulationCompleted([In] ManipulationCompletedRoutedEventArgs e);
        void OnManipulationDelta([In] ManipulationDeltaRoutedEventArgs e);
        void OnManipulationInertiaStarting([In] ManipulationInertiaStartingRoutedEventArgs e);
        void OnManipulationStarted([In] ManipulationStartedRoutedEventArgs e);
        void OnManipulationStarting([In] ManipulationStartingRoutedEventArgs e);
        void OnPointerCanceled([In] PointerEventArgs e);
        void OnPointerCaptureLost([In] PointerEventArgs e);
        void OnPointerEntered([In] PointerEventArgs e);
        void OnPointerExited([In] PointerEventArgs e);
        void OnPointerMoved([In] PointerEventArgs e);
        void OnPointerPressed([In] PointerEventArgs e);
        void OnPointerReleased([In] PointerEventArgs e);
        void OnPointerWheelChanged([In] PointerEventArgs e);
        void OnRightTapped([In] RightTappedRoutedEventArgs e);
        void OnTapped([In] TappedRoutedEventArgs e);
    }
}

