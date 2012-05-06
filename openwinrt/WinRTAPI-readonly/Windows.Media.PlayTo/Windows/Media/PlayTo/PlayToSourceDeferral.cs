namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlayToSourceDeferral : IPlayToSourceDeferral
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();
    }
}

