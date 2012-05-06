namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa6c4bac0, 0x51f8, 0x4c57, 0xac, 0x3f, 0x15, 0x6d, 0xd1, 0x68, 12, 0x4f)]
    public delegate void BackgroundTaskCanceledEventHandler([In] IBackgroundTaskInstance sender, [In] BackgroundTaskCancellationReason reason);
}

