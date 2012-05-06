namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataProviderDeferral)), Guid(0xc2cf2373, 0x2d26, 0x43d9, 0xb6, 0x9d, 220, 0xb8, 0x6d, 3, 0xf6, 0xda), Version(0x6020000)]
    internal interface IDataProviderDeferral
    {
        void Complete();
    }
}

