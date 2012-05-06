namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(PlayToSourceSelectedEventArgs)), Guid(0xc9d8511, 0x5202, 0x4dcb, 140, 0x67, 0xab, 0xda, 0x12, 0xbb, 60, 0x12), Version(0x6020000)]
    internal interface IPlayToSourceSelectedEventArgs
    {
        string FriendlyName { get; }

        IRandomAccessStreamWithContentType Icon { get; }

        bool SupportsAudio { get; }

        bool SupportsImage { get; }

        bool SupportsVideo { get; }
    }
}

