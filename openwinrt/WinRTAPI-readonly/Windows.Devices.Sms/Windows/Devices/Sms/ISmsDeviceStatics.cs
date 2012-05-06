namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SmsDevice)), Windows.Foundation.Metadata.Guid(0xf88d07ea, 0xd815, 0x4dd1, 0xa2, 0x34, 0x45, 0x20, 0xce, 70, 4, 0xa4), Version(0x6020000)]
    internal interface ISmsDeviceStatics
    {
        IAsyncOperation<SmsDevice> FromIdAsync([In] string deviceInstanceId);
        IAsyncOperation<SmsDevice> GetDefaultAsync();
        string GetDeviceSelector();
    }
}

