namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe32bde1c, 0x28af, 0x4b90, 0x95, 0xda, 0xa3, 0xac, 0xf3, 0x20, 0xb9, 0x29), Version(0x6020000)]
    public interface IPrintCustomOptionDetails : IPrintOptionDetails
    {
        string DisplayName { get; [param: In] set; }
    }
}

