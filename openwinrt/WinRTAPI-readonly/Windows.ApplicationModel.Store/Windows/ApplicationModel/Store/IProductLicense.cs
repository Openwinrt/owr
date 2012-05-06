namespace Windows.ApplicationModel.Store
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x363308c7, 0x2bcf, 0x4c0e, 0x8f, 0x2f, 0xe8, 8, 170, 0xa8, 0xf9, 0x9d), Version(0x6020000), ExclusiveTo(typeof(ProductLicense))]
    internal interface IProductLicense
    {
        Windows.Foundation.DateTime ExpirationDate { get; }

        bool IsActive { get; }

        string ProductId { get; }
    }
}

