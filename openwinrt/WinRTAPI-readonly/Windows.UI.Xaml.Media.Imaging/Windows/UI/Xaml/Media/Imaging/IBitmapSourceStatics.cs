namespace Windows.UI.Xaml.Media.Imaging
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(BitmapSource)), Guid(0x9a9c9981, 0x827b, 0x4e51, 0x89, 0x1b, 0x8a, 0x15, 0xb5, 0x11, 0x84, 0x2d)]
    internal interface IBitmapSourceStatics
    {
        DependencyProperty PixelHeightProperty { get; }

        DependencyProperty PixelWidthProperty { get; }
    }
}

