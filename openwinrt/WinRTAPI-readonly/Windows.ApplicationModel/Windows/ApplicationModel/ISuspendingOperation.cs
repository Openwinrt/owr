namespace Windows.ApplicationModel
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9da4ca41, 0x20e1, 0x4e9b, 0x9f, 0x65, 0xa9, 0xf4, 0x35, 0x34, 12, 0x3a)]
    public interface ISuspendingOperation
    {
        SuspendingDeferral GetDeferral();

        DateTime Deadline { get; }
    }
}

