namespace Windows.Devices.Sms
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SmsDataFormat
    {
        Unknown,
        CdmaSubmit,
        GsmSubmit,
        CdmaDeliver,
        GsmDeliver
    }
}

