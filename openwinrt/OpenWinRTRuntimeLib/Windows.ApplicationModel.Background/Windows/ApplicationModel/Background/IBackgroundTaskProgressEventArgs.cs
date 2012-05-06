namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BackgroundTaskProgressEventArgs)), Version(0x6020000), Guid(0xfb1468ac, 0x8332, 0x4d0a, 0x95, 50, 3, 0xea, 230, 0x84, 0xda, 0x31)]
    internal interface IBackgroundTaskProgressEventArgs
    {
        Guid InstanceId { get; }

        uint Progress { get; }
    }
}

