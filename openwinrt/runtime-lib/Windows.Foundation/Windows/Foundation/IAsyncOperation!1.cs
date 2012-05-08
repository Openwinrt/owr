namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9fc2b0bb, 0xe446, 0x44e2, 170, 0x61, 0x9c, 0xab, 0x8f, 0x63, 0x6a, 0xf2), Version(0x6020000)]
    public interface IAsyncOperation<TResult> : IAsyncInfo
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        TResult GetResults();

        AsyncOperationCompletedHandler<TResult> Completed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

