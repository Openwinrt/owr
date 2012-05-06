namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Static(typeof(ICurrentAppSimulator), 0x6020000), Version(0x6020000)]
    public static class CurrentAppSimulator
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<ListingInformation> LoadListingInformationAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction RequestAppPurchaseAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction RequestProductPurchaseAsync([In] string productId);

        public static Guid AppId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Windows.ApplicationModel.Store.LicenseInformation LicenseInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Uri LinkUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

