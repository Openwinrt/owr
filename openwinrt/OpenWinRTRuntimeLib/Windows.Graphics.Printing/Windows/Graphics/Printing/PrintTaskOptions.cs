namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskOptions : IPrintTaskOptionsCore, IPrintTaskOptionsCoreProperties, IPrintTaskOptionsCoreUIConfiguration
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintPageDescription GetPageDescription([In] uint jobPageNumber);

        public PrintBinding Binding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintCollation Collation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintColorMode ColorMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> DisplayedOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintDuplex Duplex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintHolePunch HolePunch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint MaxCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintMediaSize MediaSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintMediaType MediaType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint MinCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint NumberOfCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintOrientation Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Graphics.Printing.PrintQuality PrintQuality { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintStaple Staple { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintBinding Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.Binding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintCollation Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.Collation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintColorMode Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.ColorMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintDuplex Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.Duplex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintHolePunch Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.HolePunch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.MaxCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintMediaSize Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.MediaSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintMediaType Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.MediaType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.MinCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.NumberOfCopies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintOrientation Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Graphics.Printing.PrintQuality Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.PrintQuality { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PrintStaple Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties.Staple { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration.DisplayedOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

