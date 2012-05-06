namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ImageBrush)), Version(0x6020000), WebHostHidden, Guid(0x1255b1b2, 0xdd18, 0x42e5, 0x89, 0x2c, 0xea, 0xe3, 12, 0x30, 0x5b, 140)]
    internal interface IImageBrushStatics
    {
        DependencyProperty ImageSourceProperty { get; }
    }
}

