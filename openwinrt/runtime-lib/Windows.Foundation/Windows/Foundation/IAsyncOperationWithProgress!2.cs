namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb5d036d7, 0xe297, 0x498f, 0xba, 0x60, 2, 0x89, 0xe7, 110, 0x23, 0xdd)]
    public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        TResult GetResults();

        AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        AsyncOperationProgressHandler<TResult, TProgress> Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

