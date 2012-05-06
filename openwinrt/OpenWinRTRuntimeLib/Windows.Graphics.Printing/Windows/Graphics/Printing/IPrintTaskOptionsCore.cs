namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1bdbb474, 0x4ed1, 0x41eb, 190, 60, 0x72, 0xd1, 0x8e, 0xd6, 0x73, 0x37), Version(0x6020000)]
    public interface IPrintTaskOptionsCore
    {
        PrintPageDescription GetPageDescription([In] uint jobPageNumber);
    }
}

