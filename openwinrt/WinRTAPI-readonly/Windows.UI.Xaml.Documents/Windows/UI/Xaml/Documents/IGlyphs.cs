namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [ExclusiveTo(typeof(Glyphs)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd079498b, 0xf2b1, 0x4281, 0x99, 0xa2, 0xe4, 0xd0, 0x59, 50, 0xb2, 0xb5), WebHostHidden]
    internal interface IGlyphs
    {
        Brush Fill { get; [param: In] set; }

        double FontRenderingEmSize { get; [param: In] set; }

        Uri FontUri { get; [param: In] set; }

        string Indices { get; [param: In] set; }

        double OriginX { get; [param: In] set; }

        double OriginY { get; [param: In] set; }

        Windows.UI.Xaml.Media.StyleSimulations StyleSimulations { get; [param: In] set; }

        string UnicodeString { get; [param: In] set; }
    }
}

