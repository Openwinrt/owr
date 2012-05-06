namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToConnectionErrorEventArgs : IPlayToConnectionErrorEventArgs
    {
        public PlayToConnectionError Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToConnectionError Windows.Media.PlayTo.IPlayToConnectionErrorEventArgs.Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.PlayTo.IPlayToConnectionErrorEventArgs.Message { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

