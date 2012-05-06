namespace Windows.System
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Static(typeof(ILauncherStatics), 0x6020000)]
    public static class Launcher
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LaunchFileAsync")]
        public static IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LaunchFileWithOptionsAsync")]
        public static IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file, [In] LauncherOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LaunchUriAsync")]
        public static IAsyncOperation<bool> LaunchUriAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LaunchUriWithOptionsAsync")]
        public static IAsyncOperation<bool> LaunchUriAsync([In] Uri uri, [In] LauncherOptions options);
    }
}

