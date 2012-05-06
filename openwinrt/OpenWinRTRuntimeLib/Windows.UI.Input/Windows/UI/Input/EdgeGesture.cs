namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IEdgeGestureStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.STA)]
    public sealed class EdgeGesture : IEdgeGesture
    {
        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;

        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;

        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;

        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Windows.UI.Input.IEdgeGesture.Canceled;

        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Windows.UI.Input.IEdgeGesture.Completed;

        public event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Windows.UI.Input.IEdgeGesture.Starting;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static EdgeGesture GetForCurrentView();
    }
}

