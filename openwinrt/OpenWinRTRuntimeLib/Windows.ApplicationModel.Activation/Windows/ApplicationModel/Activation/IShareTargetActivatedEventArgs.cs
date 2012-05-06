namespace Windows.ApplicationModel.Activation
{
    using Windows.ApplicationModel.DataTransfer.ShareTarget;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x4bdaf9c8, 0xcdb2, 0x4acb, 0xbf, 0xc3, 0x66, 0x48, 0x56, 0x33, 120, 0xec)]
    public interface IShareTargetActivatedEventArgs : IActivatedEventArgs
    {
        Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation ShareOperation { get; }
    }
}

