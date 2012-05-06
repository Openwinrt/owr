namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BackgroundTaskCompletedEventArgs)), Guid(0x565d25cf, 0xf209, 0x48f4, 0x99, 0x67, 0x2b, 0x18, 0x4f, 0x7b, 0xfb, 240), Version(0x6020000)]
    internal interface IBackgroundTaskCompletedEventArgs
    {
        Guid InstanceId { get; }

        HResult Status { get; }
    }
}

