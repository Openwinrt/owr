namespace Windows.UI.WebUI
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(WebUIBackgroundTaskInstance)), Guid(0x9c7a5291, 0x19ae, 0x4ca3, 0xb9, 0x4b, 0xfe, 0x4e, 0xc7, 0x44, 0xa7, 0x40), Version(0x6020000)]
    internal interface IWebUIBackgroundTaskInstanceStatics
    {
        IWebUIBackgroundTaskInstance Current { get; }
    }
}

