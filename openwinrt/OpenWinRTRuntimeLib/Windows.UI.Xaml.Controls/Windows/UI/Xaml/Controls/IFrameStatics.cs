namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0xd5acf0e9, 0xd967, 0x471b, 0x84, 0x59, 200, 0xaf, 0x43, 0x41, 0x51, 0x1b), Version(0x6020000), ExclusiveTo(typeof(Frame))]
    internal interface IFrameStatics
    {
        DependencyProperty CacheSizeProperty { get; }

        DependencyProperty CanGoBackProperty { get; }

        DependencyProperty CanGoForwardProperty { get; }

        DependencyProperty CurrentSourcePageTypeProperty { get; }

        DependencyProperty SourcePageTypeProperty { get; }
    }
}

