namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToSource : IPlayToSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PlayNext();

        public PlayToConnection Connection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSource Next { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PlayToConnection Windows.Media.PlayTo.IPlayToSource.Connection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlayToSource Windows.Media.PlayTo.IPlayToSource.Next { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

