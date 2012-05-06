namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x36, 0, 0, 0xc0, 0, 0, 0, 0, 0, 0, 70)]
    public interface IAsyncInfo
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Cancel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void Close();

        HResult ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        AsyncStatus Status { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

