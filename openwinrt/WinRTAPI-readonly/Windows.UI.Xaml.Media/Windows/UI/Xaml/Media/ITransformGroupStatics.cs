namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0x25312f2a, 0xcfab, 0x4b24, 0x97, 0x13, 0x5b, 0xde, 0xad, 0x19, 0x29, 0xc0), ExclusiveTo(typeof(TransformGroup)), WebHostHidden]
    internal interface ITransformGroupStatics
    {
        DependencyProperty ChildrenProperty { get; }
    }
}

