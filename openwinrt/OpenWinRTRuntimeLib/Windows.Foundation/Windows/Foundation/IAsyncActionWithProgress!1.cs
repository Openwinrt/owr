namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1f6db258, 0xe803, 0x48a1, 0x95, 70, 0xeb, 0x73, 0x53, 0x39, 0x88, 0x84), Version(0x6020000)]
    public interface IAsyncActionWithProgress<TProgress> : IAsyncInfo
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        void GetResults();

        AsyncActionWithProgressCompletedHandler<TProgress> Completed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        AsyncActionProgressHandler<TProgress> Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

