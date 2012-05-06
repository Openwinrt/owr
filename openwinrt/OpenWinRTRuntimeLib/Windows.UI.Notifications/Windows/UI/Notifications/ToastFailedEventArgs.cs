namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ToastFailedEventArgs : IToastFailedEventArgs
    {
        public HResult ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HResult Windows.UI.Notifications.IToastFailedEventArgs.ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

