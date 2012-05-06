namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5b38e929, 0xa086, 0x46a7, 0xa6, 120, 0x43, 0x91, 0x35, 130, 0x2b, 0xcf)]
    public delegate void BackgroundTaskCompletedEventHandler([In] BackgroundTaskRegistration sender, [In] BackgroundTaskCompletedEventArgs args);
}

