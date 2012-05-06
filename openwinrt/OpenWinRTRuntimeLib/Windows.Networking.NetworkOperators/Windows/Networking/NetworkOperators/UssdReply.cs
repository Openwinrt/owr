namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class UssdReply : IUssdReply
    {
        public UssdMessage Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UssdResultCode ResultCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UssdMessage Windows.Networking.NetworkOperators.IUssdReply.Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UssdResultCode Windows.Networking.NetworkOperators.IUssdReply.ResultCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

