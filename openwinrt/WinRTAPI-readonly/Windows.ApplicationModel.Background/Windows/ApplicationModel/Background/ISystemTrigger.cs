namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SystemTrigger)), Guid(0x72e45d53, 0x39fb, 0x46ac, 0x91, 0xb6, 0xaf, 0x62, 0x3b, 0x3d, 0xd5, 3), Version(0x6020000)]
    internal interface ISystemTrigger : IBackgroundTrigger
    {
        bool OneShot { get; }

        SystemTriggerType TriggerType { get; }
    }
}

