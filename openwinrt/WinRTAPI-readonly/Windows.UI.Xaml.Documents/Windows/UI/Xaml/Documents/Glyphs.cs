namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IGlyphsStatics), 0x6020000)]
    public sealed class Glyphs : FrameworkElement, IGlyphs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Glyphs();

        public Brush Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double FontRenderingEmSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontRenderingEmSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri FontUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FontUriProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Indices { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IndicesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double OriginX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OriginXProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double OriginY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OriginYProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.StyleSimulations StyleSimulations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StyleSimulationsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UnicodeString { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty UnicodeStringProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Windows.UI.Xaml.Documents.IGlyphs.Fill { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Documents.IGlyphs.FontRenderingEmSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.Xaml.Documents.IGlyphs.FontUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Documents.IGlyphs.Indices { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Documents.IGlyphs.OriginX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Documents.IGlyphs.OriginY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.StyleSimulations Windows.UI.Xaml.Documents.IGlyphs.StyleSimulations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Documents.IGlyphs.UnicodeString { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

