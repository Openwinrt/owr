namespace Windows.ApplicationModel.Background
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x90089cc6, 0x63cd, 0x480c, 0x95, 0xd1, 110, 0x6a, 0xef, 0x80, 30, 0x4a), ExclusiveTo(typeof(NetworkOperatorNotificationTrigger)), Version(0x6020000)]
    internal interface INetworkOperatorNotificationTrigger : IBackgroundTrigger
    {
        string NetworkAccountId { get; }
    }
}

