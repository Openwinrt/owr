namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class TileUpdater : ITileUpdater
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddToSchedule([In] ScheduledTileNotification scheduledTile);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void EnableNotificationQueue([In] bool enable);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveFromSchedule([In] ScheduledTileNotification scheduledTile);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPeriodicUpdate")]
        public void StartPeriodicUpdate([In] Uri tileContent, [In] PeriodicUpdateRecurrence requestedInterval);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPeriodicUpdateAtTime")]
        public void StartPeriodicUpdate([In] Uri tileContent, [In] Windows.Foundation.DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StopPeriodicUpdate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Update([In] TileNotification notification);

        public NotificationSetting Setting { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public NotificationSetting Windows.UI.Notifications.ITileUpdater.Setting { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

