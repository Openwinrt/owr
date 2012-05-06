namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MediaProtectionServiceCompletion : IMediaProtectionServiceCompletion
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete([In] bool success);
    }
}

