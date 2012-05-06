namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xbb2afc33, 0x93b1, 0x42ed, 0x8b, 0x26, 0x23, 0x6d, 0xd9, 0xc7, 0x84, 150)]
    public interface IFileActivatedEventArgs : IActivatedEventArgs
    {
        IVectorView<IStorageItem> Files { get; }

        string Verb { get; }
    }
}

