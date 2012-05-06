namespace Windows.UI.Notifications
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x35176862, 0xcfd4, 0x44f8, 0xad, 100, 0xf5, 0, 0xfd, 0x89, 0x6c, 0x3b), ExclusiveTo(typeof(ToastFailedEventArgs)), Version(0x6020000)]
    internal interface IToastFailedEventArgs
    {
        HResult ErrorCode { get; }
    }
}

