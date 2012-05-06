namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb7ad409, 0xec2d, 0x47ce, 0xa2, 0x53, 0x73, 0x2b, 0xee, 0xeb, 0xca, 0xcd)]
    public delegate void SmsMessageReceivedEventHandler([In] SmsDevice sender, [In] SmsMessageReceivedEventArgs e);
}

