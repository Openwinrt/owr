namespace Windows.System.UserProfile
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x3ee9d3ad, 0xb607, 0x40ae, 180, 0x26, 0x76, 0x31, 0xd9, 130, 0x12, 0x69), ExclusiveTo(typeof(LockScreen))]
    internal interface ILockScreenStatics
    {
        IRandomAccessStream GetImageStream();
        IAsyncAction SetImageFileAsync([In] IStorageFile value);
        IAsyncAction SetImageStreamAsync([In] IRandomAccessStream value);

        Uri OriginalImageFile { get; }
    }
}

