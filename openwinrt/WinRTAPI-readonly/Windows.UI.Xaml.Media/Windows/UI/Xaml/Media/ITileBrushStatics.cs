namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Guid(0x3497c25b, 0xb562, 0x4e68, 0x84, 0x35, 0x23, 0x99, 0xf6, 0xeb, 0x94, 0xd5), ExclusiveTo(typeof(TileBrush))]
    internal interface ITileBrushStatics
    {
        DependencyProperty AlignmentXProperty { get; }

        DependencyProperty AlignmentYProperty { get; }

        DependencyProperty StretchProperty { get; }
    }
}

