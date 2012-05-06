namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CurrentAppSimulator)), Windows.Foundation.Metadata.Guid(0xf17f9db1, 0x74cd, 0x4787, 0x97, 0x87, 0x19, 0x86, 110, 0x9a, 0x55, 0x59), Version(0x6020000)]
    internal interface ICurrentAppSimulator
    {
        IAsyncOperation<ListingInformation> LoadListingInformationAsync();
        IAsyncAction RequestAppPurchaseAsync();
        IAsyncAction RequestProductPurchaseAsync([In] string productId);

        Guid AppId { get; }

        Windows.ApplicationModel.Store.LicenseInformation LicenseInformation { get; }

        Uri LinkUri { get; }
    }
}

