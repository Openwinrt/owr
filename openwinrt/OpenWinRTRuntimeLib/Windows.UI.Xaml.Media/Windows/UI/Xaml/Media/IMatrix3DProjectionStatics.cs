namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0xae9d5895, 0x41ec, 0x4e37, 0xab, 170, 0x69, 0xf4, 0x1d, 0x2f, 0x87, 0x6b), WebHostHidden, ExclusiveTo(typeof(Matrix3DProjection)), Version(0x6020000)]
    internal interface IMatrix3DProjectionStatics
    {
        DependencyProperty ProjectionMatrixProperty { get; }
    }
}

