namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Guid(0x1e438ded, 0x7da6, 0x409e, 0x80, 110, 0x30, 90, 0xe4, 0xad, 0x9b, 0x3f), ExclusiveTo(typeof(CaptureElement))]
    internal interface ICaptureElementStatics
    {
        DependencyProperty SourceProperty { get; }

        DependencyProperty StretchProperty { get; }
    }
}

