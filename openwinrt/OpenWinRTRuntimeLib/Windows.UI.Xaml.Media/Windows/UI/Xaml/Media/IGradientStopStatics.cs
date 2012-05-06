namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Guid(0x602a6d75, 0x6193, 0x4fe5, 0x8e, 130, 0xc7, 0xc6, 0xf6, 0xfe, 0xba, 0xfd), ExclusiveTo(typeof(GradientStop))]
    internal interface IGradientStopStatics
    {
        DependencyProperty ColorProperty { get; }

        DependencyProperty OffsetProperty { get; }
    }
}

