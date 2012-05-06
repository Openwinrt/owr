namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SmsMessageReceivedEventArgs : ISmsMessageReceivedEventArgs
    {
        public SmsBinaryMessage BinaryMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsTextMessage TextMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsBinaryMessage Windows.Devices.Sms.ISmsMessageReceivedEventArgs.BinaryMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SmsTextMessage Windows.Devices.Sms.ISmsMessageReceivedEventArgs.TextMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

