namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(EdgeGesture)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x580d5292, 0x2ab1, 0x49aa, 0xa7, 240, 0x33, 0xbd, 0x3f, 0x8d, 0xf9, 0xf1)]
    internal interface IEdgeGesture
    {
        event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;

        event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;

        event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;
    }
}

