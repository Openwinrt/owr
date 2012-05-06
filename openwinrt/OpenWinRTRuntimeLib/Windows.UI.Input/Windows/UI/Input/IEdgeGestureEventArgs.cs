namespace Windows.UI.Input
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(EdgeGestureEventArgs)), Guid(0x44fa4a24, 0x2d09, 0x42e1, 0x8b, 0x5e, 0x36, 130, 8, 0x79, 0x6a, 0x4c)]
    internal interface IEdgeGestureEventArgs
    {
        EdgeGestureKind Kind { get; }
    }
}

