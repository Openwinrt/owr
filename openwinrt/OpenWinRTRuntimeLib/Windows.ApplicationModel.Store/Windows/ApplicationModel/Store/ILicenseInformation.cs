namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8eb7dc30, 0xf170, 0x4ed5, 0x8e, 0x21, 0x15, 0x16, 0xda, 0x3f, 0xd3, 0x67), ExclusiveTo(typeof(LicenseInformation))]
    internal interface ILicenseInformation
    {
        event LicenseChangedEventHandler LicenseChanged;

        Windows.Foundation.DateTime ExpirationDate { get; }

        bool IsActive { get; }

        bool IsTrial { get; }

        IMapView<string, ProductLicense> ProductLicenses { get; }
    }
}

