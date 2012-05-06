namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x55690902, 0xaab, 0x421a, 0x87, 120, 0xf8, 0xce, 80, 0x26, 0xd7, 0x58), Version(0x6020000)]
    public delegate void AsyncOperationProgressHandler<TResult, TProgress>([In] IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, [In] TProgress progressInfo);
}

