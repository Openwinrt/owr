namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x865bda7a, 0x21d8, 0x4573, 0x8f, 50, 0x92, 0x8a, 0x1b, 6, 0x41, 0xf6), Version(0x6020000)]
    public interface IBackgroundTaskInstance
    {
        event BackgroundTaskCanceledEventHandler Canceled;

        BackgroundTaskDeferral GetDeferral();

        Guid InstanceId { get; }

        uint Progress { get; [param: In] set; }

        uint SuspendedCount { get; }

        BackgroundTaskRegistration Task { get; }

        object TriggerDetails { get; }
    }
}

