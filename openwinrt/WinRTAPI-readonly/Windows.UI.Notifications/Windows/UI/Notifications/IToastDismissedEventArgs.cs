namespace Windows.UI.Notifications
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ToastDismissedEventArgs)), Guid(0x3f89d935, 0xd9cb, 0x4538, 160, 240, 0xff, 0xe7, 0x65, 0x99, 0x38, 0xf8), Version(0x6020000)]
    internal interface IToastDismissedEventArgs
    {
        ToastDismissalReason Reason { get; }
    }
}

