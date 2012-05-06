namespace Windows.System
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0x277151c3, 0x9e3e, 0x42f6, 0x91, 0xa4, 0x5d, 0xfd, 0xeb, 0x23, 0x24, 0x51), Version(0x6020000), ExclusiveTo(typeof(Launcher))]
    internal interface ILauncherStatics
    {
        [Overload("LaunchFileAsync")]
        IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file);
        [Overload("LaunchFileWithOptionsAsync")]
        IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file, [In] LauncherOptions options);
        [Overload("LaunchUriAsync")]
        IAsyncOperation<bool> LaunchUriAsync([In] Uri uri);
        [Overload("LaunchUriWithOptionsAsync")]
        IAsyncOperation<bool> LaunchUriAsync([In] Uri uri, [In] LauncherOptions options);
    }
}

