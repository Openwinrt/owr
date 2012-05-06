namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x10654cc2, 0xa26e, 0x43bf, 140, 0x12, 0x1f, 180, 13, 0xbf, 0xbf, 160)]
    public interface IBackgroundTaskRegistration
    {
        event BackgroundTaskCompletedEventHandler Completed;

        event BackgroundTaskProgressEventHandler Progress;

        void Unregister([In] bool cancelTask);

        string Name { get; }

        Guid TaskId { get; }
    }
}

