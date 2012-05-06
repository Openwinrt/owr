namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CurrentApp)), Windows.Foundation.Metadata.Guid(0xd52dc065, 0xda3f, 0x4685, 0x99, 0x5e, 0x9b, 0x48, 0x2e, 0xb5, 230, 3), Version(0x6020000)]
    internal interface ICurrentApp
    {
        IAsyncOperation<ListingInformation> LoadListingInformationAsync();
        IAsyncAction RequestAppPurchaseAsync();
        IAsyncAction RequestProductPurchaseAsync([In] string productId);

        Guid AppId { get; }

        Windows.ApplicationModel.Store.LicenseInformation LicenseInformation { get; }

        Uri LinkUri { get; }
    }
}

