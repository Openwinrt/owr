namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.MTA), Static(typeof(IUssdSessionStatics), 0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class UssdSession : IUssdSession
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static UssdSession CreateFromNetworkAccountId([In] string networkAccountId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static UssdSession CreateFromNetworkInterfaceId([In] string networkInterfaceId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<UssdReply> SendMessageAndGetReplyAsync([In] UssdMessage message);
    }
}

