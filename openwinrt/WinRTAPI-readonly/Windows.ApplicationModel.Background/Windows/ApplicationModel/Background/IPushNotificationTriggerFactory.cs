namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x6dd8ed1b, 0x458e, 0x4fc2, 0xbc, 0x2e, 0xd5, 0x66, 0x4f, 0x77, 0xed, 0x19), ExclusiveTo(typeof(PushNotificationTrigger)), Version(0x6020000)]
    internal interface IPushNotificationTriggerFactory
    {
        PushNotificationTrigger Create([In] string applicationId);
    }
}

