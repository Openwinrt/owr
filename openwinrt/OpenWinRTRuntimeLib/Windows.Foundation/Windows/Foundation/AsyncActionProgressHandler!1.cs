namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6d844858, 0xcff, 0x4590, 0xae, 0x89, 0x95, 0xa5, 0xa5, 200, 180, 0xb8)]
    public delegate void AsyncActionProgressHandler<TProgress>([In] IAsyncActionWithProgress<TProgress> asyncInfo, [In] TProgress progressInfo);
}

