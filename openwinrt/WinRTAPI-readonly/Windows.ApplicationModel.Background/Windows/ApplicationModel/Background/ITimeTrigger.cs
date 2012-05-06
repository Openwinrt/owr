namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x656e5556, 0xb2a, 0x4377, 0xba, 0x70, 0x3b, 0x45, 0xa9, 0x35, 0x54, 0x7f), ExclusiveTo(typeof(TimeTrigger))]
    internal interface ITimeTrigger : IBackgroundTrigger
    {
        uint FreshnessTime { get; }

        bool OneShot { get; }
    }
}

