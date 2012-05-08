namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9c029f91, 0xcc84, 0x44fd, 0xac, 0x26, 10, 0x6c, 0x4e, 0x55, 0x52, 0x81), Version(0x6020000)]
    public delegate void AsyncActionWithProgressCompletedHandler<TProgress>([In] IAsyncActionWithProgress<TProgress> asyncInfo, [In] AsyncStatus asyncStatus);
}

