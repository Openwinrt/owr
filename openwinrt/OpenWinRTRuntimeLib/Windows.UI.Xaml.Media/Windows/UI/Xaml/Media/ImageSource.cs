namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IImageSourceFactory), CompositionType.Protected, 0x6020000)]
    public class ImageSource : DependencyObject, IImageSource
    {
    }
}

