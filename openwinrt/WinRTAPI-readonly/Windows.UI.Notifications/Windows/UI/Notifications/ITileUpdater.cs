namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x942a48b, 0x1d91, 0x44ec, 0x92, 0x43, 0xc1, 0xe8, 0x21, 0xc2, 0x9a, 0x20), ExclusiveTo(typeof(TileUpdater)), Version(0x6020000)]
    internal interface ITileUpdater
    {
        void AddToSchedule([In] ScheduledTileNotification scheduledTile);
        void Clear();
        void EnableNotificationQueue([In] bool enable);
        IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();
        void RemoveFromSchedule([In] ScheduledTileNotification scheduledTile);
        [Overload("StartPeriodicUpdate")]
        void StartPeriodicUpdate([In] Uri tileContent, [In] PeriodicUpdateRecurrence requestedInterval);
        [Overload("StartPeriodicUpdateAtTime")]
        void StartPeriodicUpdate([In] Uri tileContent, [In] Windows.Foundation.DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
        void StopPeriodicUpdate();
        void Update([In] TileNotification notification);

        NotificationSetting Setting { get; }
    }
}

