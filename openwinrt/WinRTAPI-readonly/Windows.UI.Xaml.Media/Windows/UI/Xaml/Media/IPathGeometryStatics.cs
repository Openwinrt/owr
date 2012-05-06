namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(PathGeometry)), Guid(0xd9e58bba, 0x2cba, 0x4741, 0x8f, 0x8d, 0x31, 0x98, 0xcf, 0x51, 0x86, 0xb9)]
    internal interface IPathGeometryStatics
    {
        DependencyProperty FiguresProperty { get; }

        DependencyProperty FillRuleProperty { get; }
    }
}

