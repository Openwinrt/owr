namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ListingInformation : IListingInformation
    {
        public uint AgeRating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CurrentMarket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Description { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FormattedPrice { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ProductListing> ProductListings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Store.IListingInformation.AgeRating { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Store.IListingInformation.CurrentMarket { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Store.IListingInformation.Description { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Store.IListingInformation.FormattedPrice { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Store.IListingInformation.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, ProductListing> Windows.ApplicationModel.Store.IListingInformation.ProductListings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

