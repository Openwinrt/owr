namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000)]
    public sealed class SourceChangeRequestedEventArgs : ISourceChangeRequestedEventArgs
    {
        public IRandomAccessStreamWithContentType Stream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IRandomAccessStreamWithContentType Windows.Media.PlayTo.ISourceChangeRequestedEventArgs.Stream { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

