namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IThumbStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000)]
    public sealed class Thumb : Control, IThumb
    {
        public event DragCompletedEventHandler DragCompleted;

        public event DragDeltaEventHandler DragDelta;

        public event DragStartedEventHandler DragStarted;

        public event DragCompletedEventHandler Windows.UI.Xaml.Controls.Primitives.IThumb.DragCompleted;

        public event DragDeltaEventHandler Windows.UI.Xaml.Controls.Primitives.IThumb.DragDelta;

        public event DragStartedEventHandler Windows.UI.Xaml.Controls.Primitives.IThumb.DragStarted;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Thumb();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CancelDrag();

        public bool IsDragging { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsDraggingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IThumb.IsDragging { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

