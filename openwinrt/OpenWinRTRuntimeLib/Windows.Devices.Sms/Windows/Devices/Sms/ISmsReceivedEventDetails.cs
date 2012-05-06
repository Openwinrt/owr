namespace Windows.Devices.Sms
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SmsReceivedEventDetails)), Version(0x6020000), Guid(0x5bb50f15, 0xe46d, 0x4c82, 0x84, 0x7d, 90, 3, 4, 0xc1, 0xd5, 0x3d)]
    internal interface ISmsReceivedEventDetails
    {
        string DeviceId { get; }

        uint MessageIndex { get; }
    }
}

