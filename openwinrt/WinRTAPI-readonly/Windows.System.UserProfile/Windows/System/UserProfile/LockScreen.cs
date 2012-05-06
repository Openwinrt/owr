namespace Windows.System.UserProfile
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(ILockScreenStatics), 0x6020000)]
    public static class LockScreen
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IRandomAccessStream GetImageStream();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction SetImageFileAsync([In] IStorageFile value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncAction SetImageStreamAsync([In] IRandomAccessStream value);

        public static Uri OriginalImageFile { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

