namespace Windows.ApplicationModel.Store
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x45a7d6ad, 0xc750, 0x4d9c, 0x94, 0x7c, 0xb0, 13, 0xcb, 0xf9, 0xe9, 0xc2), ExclusiveTo(typeof(ProductListing))]
    internal interface IProductListing
    {
        string FormattedPrice { get; }

        string Name { get; }

        string ProductId { get; }
    }
}

