namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PermilleFormatter)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2b37b4ac, 0xe638, 0x4ed5, 0xa9, 0x98, 0x62, 0xf6, 0xb0, 0x6a, 0x49, 0xae)]
    internal interface IPermilleFormatterFactory
    {
        PermilleFormatter CreatePermilleFormatter([In] IIterable<string> languages, [In] string geographicRegion);
    }
}

