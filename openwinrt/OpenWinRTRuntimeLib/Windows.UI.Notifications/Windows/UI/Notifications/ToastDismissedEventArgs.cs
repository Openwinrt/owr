namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class ToastDismissedEventArgs : IToastDismissedEventArgs
    {
        public ToastDismissalReason Reason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ToastDismissalReason Windows.UI.Notifications.IToastDismissedEventArgs.Reason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

