namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2ad171f8, 0xc8bd, 0x4905, 0x91, 0x92, 13, 0x75, 0x13, 110, 0x8b, 0x31), Version(0x6020000), ExclusiveTo(typeof(PrintCustomTextOptionDetails))]
    internal interface IPrintCustomTextOptionDetails : IPrintCustomOptionDetails, IPrintOptionDetails
    {
        uint MaxCharacters { get; [param: In] set; }
    }
}

