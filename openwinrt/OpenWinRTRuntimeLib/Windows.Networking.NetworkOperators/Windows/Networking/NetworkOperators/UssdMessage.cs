namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(IUssdMessageFactory), 0x6020000)]
    public sealed class UssdMessage : IUssdMessage
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UssdMessage([In] string messageText);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public byte[] GetPayload();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPayload([In, Range(0, 160)] byte[] value);

        public byte DataCodingScheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string PayloadAsText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte Windows.Networking.NetworkOperators.IUssdMessage.DataCodingScheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.NetworkOperators.IUssdMessage.PayloadAsText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

