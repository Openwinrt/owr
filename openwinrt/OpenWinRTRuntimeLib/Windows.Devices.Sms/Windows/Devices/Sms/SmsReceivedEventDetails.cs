namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class SmsReceivedEventDetails : ISmsReceivedEventDetails
    {
        public string DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MessageIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Sms.ISmsReceivedEventDetails.DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Sms.ISmsReceivedEventDetails.MessageIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

