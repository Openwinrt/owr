namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Guid(0xf627e59d, 0x87dc, 0x4142, 0x81, 0xf1, 0x97, 0xfc, 0x7f, 0xf8, 100, 0x1c), ExclusiveTo(typeof(Path))]
    internal interface IPathStatics
    {
        DependencyProperty DataProperty { get; }
    }
}

