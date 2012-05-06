namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc1b71832, 0x9e93, 0x4e55, 0x81, 0x4b, 0x33, 0x26, 0xa5, 0x9e, 0xfc, 0xe1), Version(0x6020000)]
    public interface IPrintTaskOptionsCoreProperties
    {
        PrintBinding Binding { get; [param: In] set; }

        PrintCollation Collation { get; [param: In] set; }

        PrintColorMode ColorMode { get; [param: In] set; }

        PrintDuplex Duplex { get; [param: In] set; }

        PrintHolePunch HolePunch { get; [param: In] set; }

        uint MaxCopies { get; }

        PrintMediaSize MediaSize { get; [param: In] set; }

        PrintMediaType MediaType { get; [param: In] set; }

        uint MinCopies { get; }

        uint NumberOfCopies { get; [param: In] set; }

        PrintOrientation Orientation { get; [param: In] set; }

        Windows.Graphics.Printing.PrintQuality PrintQuality { get; [param: In] set; }

        PrintStaple Staple { get; [param: In] set; }
    }
}

