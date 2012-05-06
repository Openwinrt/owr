namespace Windows.ApplicationModel.Store
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ProductLicense : IProductLicense
    {
        public Windows.Foundation.DateTime ExpirationDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ProductId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.ApplicationModel.Store.IProductLicense.ExpirationDate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Store.IProductLicense.IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Store.IProductLicense.ProductId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

