namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DecimalFormatter)), Windows.Foundation.Metadata.Guid(0xd018c9a, 0xe393, 0x46b8, 0xb8, 0x30, 0x7a, 0x69, 200, 0xf8, 0x9f, 0xbb), Version(0x6020000)]
    internal interface IDecimalFormatterFactory
    {
        DecimalFormatter CreateDecimalFormatter([In] IIterable<string> languages, [In] string geographicRegion);
    }
}

