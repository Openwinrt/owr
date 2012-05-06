namespace Windows.System.UserProfile
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Static(typeof(IUserInformationStatics), 0x6020000), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public static class UserInformation
    {
        public static  event Windows.Foundation.EventHandler<object> AccountPictureChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IStorageFile GetAccountPicture([In] AccountPictureKind kind);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<string> GetDomainNameAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<string> GetPrincipalNameAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync([In] IStorageFile image);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync([In] IRandomAccessStream image);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync([In] IStorageFile smallImage, [In] IStorageFile largImage, [In] IStorageFile video);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync([In] IRandomAccessStream smallImage, [In] IRandomAccessStream largeImage, [In] IRandomAccessStream video);

        public static bool AccountPictureChangeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string FirstName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string LastName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static bool NameAccessAllowed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

