namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8b5cca18, 0xcfd5, 0x44ee, 0xa2, 0xed, 0xdf, 0x76, 1, 12, 20, 0xb5), ExclusiveTo(typeof(MediaProtectionServiceCompletion))]
    internal interface IMediaProtectionServiceCompletion
    {
        void Complete([In] bool success);
    }
}

