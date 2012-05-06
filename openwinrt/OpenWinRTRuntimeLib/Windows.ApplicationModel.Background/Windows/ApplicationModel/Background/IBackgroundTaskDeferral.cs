namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x93cc156d, 0xaf27, 0x4dd3, 0x84, 110, 0x24, 0xee, 0x40, 0xca, 0xdd, 0x25), ExclusiveTo(typeof(BackgroundTaskDeferral))]
    internal interface IBackgroundTaskDeferral
    {
        void Complete();
    }
}

