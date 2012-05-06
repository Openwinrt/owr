namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MaintenanceTrigger)), Guid(0x68184c83, 0xfc22, 0x4ce5, 0x84, 0x1a, 0x72, 0x39, 0xa9, 0x81, 0, 0x47)]
    internal interface IMaintenanceTrigger : IBackgroundTrigger
    {
        uint FreshnessTime { get; }

        bool OneShot { get; }
    }
}

