namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DataRequestDeferral)), Guid(0x6dc4b89f, 0x386, 0x4263, 0x87, 0xc1, 0xed, 0x7d, 0xce, 0x30, 0x89, 14)]
    internal interface IDataRequestDeferral
    {
        void Complete();
    }
}

