namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe85df41d, 0x6aa7, 0x46e3, 0xa8, 0xe2, 240, 9, 0xd8, 0x40, 0xc6, 0x27)]
    public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>([In] IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, [In] AsyncStatus asyncStatus);
}

