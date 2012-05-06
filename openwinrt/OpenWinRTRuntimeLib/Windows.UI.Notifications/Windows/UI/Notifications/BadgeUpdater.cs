namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class BadgeUpdater : IBadgeUpdater
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPeriodicUpdate")]
        public void StartPeriodicUpdate([In] Uri badgeContent, [In] PeriodicUpdateRecurrence requestedInterval);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("StartPeriodicUpdateAtTime")]
        public void StartPeriodicUpdate([In] Uri badgeContent, [In] Windows.Foundation.DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StopPeriodicUpdate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Update([In] BadgeNotification notification);
    }
}

