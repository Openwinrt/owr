namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe6659412, 0x4a13, 0x4a53, 0x83, 0xa1, 0x39, 0x2f, 190, 0x4c, 0xff, 0x9f)]
    public interface INumberParser
    {
        IReference<double> ParseDouble([In] string text);
        IReference<long> ParseInt([In] string text);
        IReference<ulong> ParseUInt([In] string text);
    }
}

