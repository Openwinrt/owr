namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000)]
    public sealed class PlayToSourceSelectedEventArgs : IPlayToSourceSelectedEventArgs
    {
        public string FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IRandomAccessStreamWithContentType Icon { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool SupportsAudio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool SupportsImage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool SupportsVideo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs.FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IRandomAccessStreamWithContentType Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs.Icon { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs.SupportsAudio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs.SupportsImage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs.SupportsVideo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

