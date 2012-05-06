namespace Windows.Foundation.Collections
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x575933df, 0x34fe, 0x4480, 0xaf, 0x15, 7, 0x69, 0x1f, 0x3d, 0x5d, 0x9b)]
    public interface IVectorChangedEventArgs
    {
        Windows.Foundation.Collections.CollectionChange CollectionChange { get; }

        uint Index { get; }
    }
}

