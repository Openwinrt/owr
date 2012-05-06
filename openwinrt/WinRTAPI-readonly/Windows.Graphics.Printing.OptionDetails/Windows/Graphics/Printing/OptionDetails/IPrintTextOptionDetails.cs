namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xad75e563, 0x5ce4, 0x46bc, 0x99, 0x18, 0xab, 0x9f, 0xad, 20, 0x4c, 0x5b)]
    public interface IPrintTextOptionDetails : IPrintOptionDetails
    {
        uint MaxCharacters { get; }
    }
}

