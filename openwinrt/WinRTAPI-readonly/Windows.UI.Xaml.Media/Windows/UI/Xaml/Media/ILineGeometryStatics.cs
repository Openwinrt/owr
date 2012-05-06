namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x578ae763, 0x5562, 0x4ee4, 0x87, 3, 0xea, 0x40, 0x36, 0xd8, 0x91, 0xe3), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(LineGeometry))]
    internal interface ILineGeometryStatics
    {
        DependencyProperty EndPointProperty { get; }

        DependencyProperty StartPointProperty { get; }
    }
}

