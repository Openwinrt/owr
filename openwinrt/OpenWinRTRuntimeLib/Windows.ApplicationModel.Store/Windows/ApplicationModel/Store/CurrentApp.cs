namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(ICurrentApp), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public static class CurrentApp
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

