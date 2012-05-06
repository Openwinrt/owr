namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class LicenseInformation : ILicenseInformation
    {
        public event LicenseChangedEventHandler LicenseChanged;

        public event LicenseChangedEventHandler Windows.ApplicationModel.Store.ILicenseInformation.LicenseChanged;

        public Windows.Foundation.DateTime ExpirationDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsTrial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ProductLicense> ProductLicenses { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.ApplicationModel.Store.ILicenseInformation.ExpirationDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Store.ILicenseInformation.IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Store.ILicenseInformation.IsTrial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ProductLicense> Windows.ApplicationModel.Store.ILicenseInformation.ProductLicenses { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

