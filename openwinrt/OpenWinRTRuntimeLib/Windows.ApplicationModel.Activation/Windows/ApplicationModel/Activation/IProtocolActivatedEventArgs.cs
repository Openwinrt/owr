namespace Windows.ApplicationModel.Activation
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x6095f4dd, 0xb7c0, 0x46ab, 0x81, 0xfe, 0xd9, 15, 0x36, 0xd0, 13, 0x24), Version(0x6020000)]
    public interface IProtocolActivatedEventArgs : IActivatedEventArgs
    {
        Windows.Foundation.Uri Uri { get; }
    }
}

