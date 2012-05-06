namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x7c88517, 0x6cd9, 0x4452, 0x80, 0x27, 0x74, 0x23, 0xad, 150, 0xab, 0x2b), Version(0x6020000), ExclusiveTo(typeof(SystemTrigger))]
    internal interface ISystemTriggerFactory
    {
        SystemTrigger Create([In] SystemTriggerType triggerType, [In] bool oneShot);
    }
}

