namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfcdcf02c, 0xe5d8, 0x4478, 0x91, 90, 0x4d, 0x90, 0xb7, 0x4b, 0x83, 0xa5), Version(0x6020000)]
    public delegate void AsyncOperationCompletedHandler<TResult>([In] IAsyncOperation<TResult> asyncInfo, [In] AsyncStatus asyncStatus);
}

