namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(BounceEase)), Version(0x6020000), Guid(0xc0701da2, 0x4f73, 0x41c9, 0xb2, 0xcb, 0x2e, 0xa3, 0x10, 0x51, 7, 0xff)]
    internal interface IBounceEaseStatics
    {
        DependencyProperty BouncesProperty { get; }

        DependencyProperty BouncinessProperty { get; }
    }
}

