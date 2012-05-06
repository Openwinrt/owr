namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GeographicRegion)), Windows.Foundation.Metadata.Guid(0x53425270, 0x77b4, 0x426b, 0x85, 0x9f, 0x81, 0xe1, 0x9d, 0x51, 0x25, 70), Version(0x6020000)]
    internal interface IGeographicRegionFactory
    {
        GeographicRegion CreateGeographicRegion([In] string geographicRegionCode);
    }
}

