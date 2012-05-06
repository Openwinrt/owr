namespace Windows.Storage.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Static(typeof(ICachedFileUpdaterStatics), 0x6020000)]
    public static class CachedFileUpdater
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetUpdateInformation([In] IStorageFile file, [In] string contentId, [In] ReadActivationMode readMode, [In] WriteActivationMode writeMode, [In] CachedFileOptions options);
    }
}

