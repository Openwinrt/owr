namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x4d01bbaf, 0x645c, 0x4de9, 150, 0x5f, 0x6f, 0xc6, 0xbb, 0xc4, 0x7c, 0xab)]
    public interface IPrintNumberOptionDetails : IPrintOptionDetails
    {
        uint MaxValue { get; }

        uint MinValue { get; }
    }
}

