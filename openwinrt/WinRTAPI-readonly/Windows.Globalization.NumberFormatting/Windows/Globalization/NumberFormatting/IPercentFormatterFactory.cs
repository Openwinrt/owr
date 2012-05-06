namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PercentFormatter)), Windows.Foundation.Metadata.Guid(0xb7828aef, 0xfed4, 0x4018, 0xa6, 0xe2, 0xe0, 0x99, 0x61, 0xe0, 0x37, 0x65)]
    internal interface IPercentFormatterFactory
    {
        PercentFormatter CreatePercentFormatter([In] IIterable<string> languages, [In] string geographicRegion);
    }
}

