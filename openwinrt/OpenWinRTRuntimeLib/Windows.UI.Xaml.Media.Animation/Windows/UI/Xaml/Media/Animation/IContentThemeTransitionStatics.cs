namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Guid(0xe8ee385, 0x9a42, 0x4459, 0xaf, 0xa9, 0x33, 0x7d, 0xc4, 30, 0x15, 0x87), ExclusiveTo(typeof(ContentThemeTransition))]
    internal interface IContentThemeTransitionStatics
    {
        DependencyProperty HorizontalOffsetProperty { get; }

        DependencyProperty VerticalOffsetProperty { get; }
    }
}

