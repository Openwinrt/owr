namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(ICachedFileManagerStatics), 0x6020000), Version(0x6020000)]
    public static class CachedFileManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void DeferUpdates([In] IStorageFile file);
    }
}

