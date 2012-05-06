namespace Windows.Storage.Pickers.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x13043da7, 0x7fca, 0x4c2b, 0x9e, 0xca, 0x68, 0x90, 0xf9, 240, 1, 0x85), ExclusiveTo(typeof(FileRemovedEventArgs)), Version(0x6020000)]
    internal interface IFileRemovedEventArgs
    {
        string Id { get; }
    }
}

