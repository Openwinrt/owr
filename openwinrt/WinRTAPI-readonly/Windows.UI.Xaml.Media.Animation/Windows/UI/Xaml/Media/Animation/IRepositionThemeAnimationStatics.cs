namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(RepositionThemeAnimation)), WebHostHidden, Guid(0x4d92b1b1, 0x860b, 0x4bf9, 0xa5, 0x9d, 30, 0xb1, 0xcc, 190, 0x8f, 0xe0)]
    internal interface IRepositionThemeAnimationStatics
    {
        DependencyProperty FromHorizontalOffsetProperty { get; }

        DependencyProperty FromVerticalOffsetProperty { get; }

        DependencyProperty TargetNameProperty { get; }
    }
}

