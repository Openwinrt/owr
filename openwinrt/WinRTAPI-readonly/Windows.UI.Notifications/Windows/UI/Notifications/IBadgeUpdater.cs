namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BadgeUpdater)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb5fa1fd4, 0x7562, 0x4f6c, 0xbf, 0xa3, 0x1b, 110, 210, 0xe5, 0x7f, 0x2f)]
    internal interface IBadgeUpdater
    {
        void Clear();
        [Overload("StartPeriodicUpdate")]
        void StartPeriodicUpdate([In] Uri badgeContent, [In] PeriodicUpdateRecurrence requestedInterval);
        [Overload("StartPeriodicUpdateAtTime")]
        void StartPeriodicUpdate([In] Uri badgeContent, [In] Windows.Foundation.DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
        void StopPeriodicUpdate();
        void Update([In] BadgeNotification notification);
    }
}

