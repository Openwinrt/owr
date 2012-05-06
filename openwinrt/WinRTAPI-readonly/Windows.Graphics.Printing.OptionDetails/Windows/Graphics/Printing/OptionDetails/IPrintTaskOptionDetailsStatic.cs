namespace Windows.Graphics.Printing.OptionDetails
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x135da193, 0x961, 0x4b6e, 0x87, 0x66, 0xf1, 0x3b, 0x7f, 0xbc, 0xcd, 0x58), ExclusiveTo(typeof(PrintTaskOptionDetails))]
    internal interface IPrintTaskOptionDetailsStatic
    {
        PrintTaskOptionDetails GetFromPrintTaskOptions([In] PrintTaskOptions printTaskOptions);
    }
}

