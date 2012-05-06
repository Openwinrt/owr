namespace Windows.UI.Input
{
    using Windows.Foundation.Metadata;

    [Guid(0xbc6a8519, 0x18ee, 0x4043, 0x98, 0x39, 0x4f, 0xc5, 0x84, 0xd6, 10, 20), ExclusiveTo(typeof(EdgeGesture)), Version(0x6020000)]
    internal interface IEdgeGestureStatics
    {
        EdgeGesture GetForCurrentView();
    }
}

