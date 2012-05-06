namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(MatrixTransform)), Guid(0x43e02e47, 0x15b8, 0x4758, 0xbb, 0x97, 0x7d, 0x52, 0x42, 10, 0xcc, 0x5b), Version(0x6020000), WebHostHidden]
    internal interface IMatrixTransformStatics
    {
        DependencyProperty MatrixProperty { get; }
    }
}

