namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataRequest)), Windows.Foundation.Metadata.Guid(0x4341ae3b, 0xfc12, 0x4e53, 140, 2, 0xac, 0x71, 0x4c, 0x41, 90, 0x27), Version(0x6020000)]
    internal interface IDataRequest
    {
        void FailWithDisplayText([In] string value);
        DataRequestDeferral GetDeferral();

        DataPackage Data { get; [param: In] set; }

        Windows.Foundation.DateTime Deadline { get; }
    }
}

