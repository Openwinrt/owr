namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Composable(typeof(IPathSegmentFactory), CompositionType.Protected, 0x6020000), Threading(ThreadingModel.Both)]
    public class PathSegment : DependencyObject, IPathSegment
    {
    }
}

