namespace Windows.UI.Xaml.Media.Imaging
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(BitmapImage)), Guid(0x9e282143, 0x70e8, 0x437c, 0x9f, 0xa4, 0x2c, 0xbf, 0x29, 0x5c, 0xff, 0x84), WebHostHidden]
    internal interface IBitmapImageStatics
    {
        DependencyProperty CreateOptionsProperty { get; }

        DependencyProperty DecodePixelHeightProperty { get; }

        DependencyProperty DecodePixelWidthProperty { get; }

        DependencyProperty UriSourceProperty { get; }
    }
}

