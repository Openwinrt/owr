namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(Image)), WebHostHidden, Guid(0x89903772, 0xc336, 0x43d1, 0x9d, 0x51, 0xc3, 0xbb, 0xd5, 0xd5, 0xd6, 0x91)]
    internal interface IImageStatics
    {
        DependencyProperty NineGridProperty { get; }

        DependencyProperty PlayToSourceProperty { get; }

        DependencyProperty SourceProperty { get; }

        DependencyProperty StretchProperty { get; }
    }
}

