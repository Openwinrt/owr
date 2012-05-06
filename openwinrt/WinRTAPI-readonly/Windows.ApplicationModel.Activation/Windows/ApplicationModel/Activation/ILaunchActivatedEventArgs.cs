namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xfbc93e26, 0xa14a, 0x4b4f, 130, 0xb0, 0x33, 190, 0xd9, 0x20, 0xaf, 0x52)]
    public interface ILaunchActivatedEventArgs : IActivatedEventArgs
    {
        string Arguments { get; }

        string TileId { get; }
    }
}

