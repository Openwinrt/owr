namespace Windows.UI.Xaml.Documents
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x225cf4c5, 0xfdf1, 0x43ed, 0x95, 0x8f, 0x41, 0x4e, 0x86, 0xf1, 3, 0xf2), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(Glyphs))]
    internal interface IGlyphsStatics
    {
        DependencyProperty FillProperty { get; }

        DependencyProperty FontRenderingEmSizeProperty { get; }

        DependencyProperty FontUriProperty { get; }

        DependencyProperty IndicesProperty { get; }

        DependencyProperty OriginXProperty { get; }

        DependencyProperty OriginYProperty { get; }

        DependencyProperty StyleSimulationsProperty { get; }

        DependencyProperty UnicodeStringProperty { get; }
    }
}

