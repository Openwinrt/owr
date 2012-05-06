namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x955024eb, 0x36f3, 0x4672, 0xa1, 0x86, 0xba, 0xaf, 0x62, 0x6a, 0xc4, 0xad), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Thumb))]
    internal interface IThumbStatics
    {
        DependencyProperty IsDraggingProperty { get; }
    }
}

