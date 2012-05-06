namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(NetworkOperatorNotificationTrigger)), Windows.Foundation.Metadata.Guid(0xa223e00, 0x27d7, 0x4353, 0xad, 0xb9, 0x92, 0x65, 170, 0xea, 0x57, 0x9d)]
    internal interface INetworkOperatorNotificationTriggerFactory
    {
        NetworkOperatorNotificationTrigger Create([In] string networkAccountId);
    }
}

