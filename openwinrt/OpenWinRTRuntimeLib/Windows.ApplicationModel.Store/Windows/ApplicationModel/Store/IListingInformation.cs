namespace Windows.ApplicationModel.Store
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ListingInformation)), Guid(0x588b4abf, 0xbc74, 0x4383, 0xb7, 140, 0x99, 0x60, 0x63, 0x23, 0xde, 0xce)]
    internal interface IListingInformation
    {
        uint AgeRating { get; }

        string CurrentMarket { get; }

        string Description { get; }

        string FormattedPrice { get; }

        string Name { get; }

        IMapView<string, ProductListing> ProductListings { get; }
    }
}

