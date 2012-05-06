namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x46e0683c, 0x8a88, 0x4c99, 0x80, 0x4c, 0x76, 0x89, 0x7f, 0x62, 0x77, 0xa6)]
    public delegate void BackgroundTaskProgressEventHandler([In] BackgroundTaskRegistration sender, [In] BackgroundTaskProgressEventArgs args);
}

