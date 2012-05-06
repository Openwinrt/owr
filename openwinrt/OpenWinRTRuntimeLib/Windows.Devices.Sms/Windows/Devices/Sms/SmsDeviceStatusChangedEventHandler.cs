namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x982b1162, 0x3dd7, 0x4618, 0xaf, 0x89, 12, 0x27, 0x2d, 0x5d, 6, 0xd8)]
    public delegate void SmsDeviceStatusChangedEventHandler([In] SmsDevice sender);
}

