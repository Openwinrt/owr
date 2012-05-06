namespace Windows.Globalization
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x29e28974, 0x7ad9, 0x4ef4, 0x87, 0x99, 0xb3, 180, 0x4f, 0xad, 0xec, 8), ExclusiveTo(typeof(GeographicRegion))]
    internal interface IGeographicRegionStatics
    {
        bool IsSupported([In] string geographicRegionCode);
    }
}

