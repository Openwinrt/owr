namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToConnectionTransferredEventArgs : IPlayToConnectionTransferredEventArgs
    {
        public PlayToSource CurrentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSource PreviousSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSource Windows.Media.PlayTo.IPlayToConnectionTransferredEventArgs.CurrentSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSource Windows.Media.PlayTo.IPlayToConnectionTransferredEventArgs.PreviousSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

