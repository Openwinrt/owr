namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa5007c49, 0x7676, 0x4db7, 0x86, 0x31, 0x1b, 0x6f, 0xf2, 0x65, 0xca, 0xa9)]
    public interface INumberFormatter
    {
        [DefaultOverload, Overload("FormatDouble")]
        string Format([In] double value);
        [Overload("FormatInt")]
        string Format([In] long value);
        [Overload("FormatUInt")]
        string Format([In] ulong value);
    }
}

