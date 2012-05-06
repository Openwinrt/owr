namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class UserHostAuthenticationOperation : IAsyncOperation<UserHostIdentity>, IAsyncInfo
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Cancel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UserHostIdentity GetResults();

        public AsyncOperationCompletedHandler<UserHostIdentity> Completed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public HResult ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AsyncStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HResult Windows.Foundation.IAsyncInfo.ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Foundation.IAsyncInfo.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AsyncStatus Windows.Foundation.IAsyncInfo.Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

