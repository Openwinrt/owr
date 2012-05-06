namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(GeometryGroup)), Guid(0x56c955f4, 0x8496, 0x4bb6, 0xab, 240, 0x61, 0x7b, 0x1f, 0xe7, 0x8b, 0x45), WebHostHidden, Version(0x6020000)]
    internal interface IGeometryGroupStatics
    {
        DependencyProperty ChildrenProperty { get; }

        DependencyProperty FillRuleProperty { get; }
    }
}

