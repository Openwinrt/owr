namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BackgroundTaskBuilder)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x351550e, 0x3e64, 0x4572, 0xa9, 0x3a, 0x84, 7, 90, 0x37, 0xc9, 0x17)]
    internal interface IBackgroundTaskBuilder
    {
        void AddCondition([In] IBackgroundCondition condition);
        BackgroundTaskRegistration Register();
        void SetTrigger([In] IBackgroundTrigger trigger);

        string Name { get; [param: In] set; }

        string TaskEntryPoint { get; [param: In] set; }
    }
}

