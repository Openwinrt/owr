namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9fc90920, 0x7bcf, 0x4888, 0xa8, 30, 0x10, 0x2d, 0x70, 0x34, 0xd7, 0xce), ExclusiveTo(typeof(CachedFileUpdater))]
    internal interface ICachedFileUpdaterStatics
    {
        void SetUpdateInformation([In] IStorageFile file, [In] string contentId, [In] ReadActivationMode readMode, [In] WriteActivationMode writeMode, [In] CachedFileOptions options);
    }
}

