namespace Windows.Security.Cryptography.DataProtection
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9639948, 0xed22, 0x4270, 0xbd, 0x1c, 0x6d, 0x72, 0xc0, 15, 0x87, 0x87), ExclusiveTo(typeof(DataProtectionProvider))]
    internal interface IDataProtectionProvider
    {
        IAsyncOperation<IBuffer> ProtectAsync([In] IBuffer data);
        IAsyncAction ProtectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
        IAsyncOperation<IBuffer> UnprotectAsync([In] IBuffer data);
        IAsyncAction UnprotectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
    }
}

