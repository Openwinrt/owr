namespace Windows.Networking.PushNotifications
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RawNotification)), Version(0x6020000), Guid(0x1a227281, 0x3b79, 0x42ac, 0x99, 0x63, 0x22, 0xab, 0, 0xd4, 240, 0xb7)]
    internal interface IRawNotification
    {
        string Content { get; }
    }
}

