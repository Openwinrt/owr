namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToSourceRequestedEventArgs : IPlayToSourceRequestedEventArgs
    {
        public PlayToSourceRequest SourceRequest { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSourceRequest Windows.Media.PlayTo.IPlayToSourceRequestedEventArgs.SourceRequest { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

