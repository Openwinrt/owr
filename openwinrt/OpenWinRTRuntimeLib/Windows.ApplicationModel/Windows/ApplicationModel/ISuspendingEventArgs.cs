namespace Windows.ApplicationModel
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x96061c05, 0x2dba, 0x4d08, 0xb0, 0xbd, 0x2b, 0x30, 0xa1, 0x31, 0xc6, 170)]
    public interface ISuspendingEventArgs
    {
        Windows.ApplicationModel.SuspendingOperation SuspendingOperation { get; }
    }
}

