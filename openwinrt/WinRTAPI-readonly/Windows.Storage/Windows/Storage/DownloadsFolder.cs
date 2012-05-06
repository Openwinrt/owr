namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IDownloadsFolderStatics), 0x6020000), Version(0x6020000)]
    public static class DownloadsFolder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
    }
}

