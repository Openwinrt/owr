namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Rectangle)), Version(0x6020000), Guid(0x9f25aa53, 0xbb3a, 0x4c3c, 0x89, 0xdb, 0x6f, 0xbc, 13, 0x1f, 160, 0xcc), WebHostHidden]
    internal interface IRectangleStatics
    {
        DependencyProperty RadiusXProperty { get; }

        DependencyProperty RadiusYProperty { get; }
    }
}

