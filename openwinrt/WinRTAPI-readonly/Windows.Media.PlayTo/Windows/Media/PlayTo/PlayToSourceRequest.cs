namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToSourceRequest : IPlayToSourceRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void DisplayErrorString([In] string errorString);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PlayToSourceDeferral GetDeferral();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSource([In] PlayToSource value);

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Media.PlayTo.IPlayToSourceRequest.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

