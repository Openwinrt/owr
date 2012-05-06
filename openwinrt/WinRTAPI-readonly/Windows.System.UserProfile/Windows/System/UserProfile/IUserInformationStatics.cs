namespace Windows.System.UserProfile
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x3c1db333, 0xf8dc, 0x49d6, 0xb7, 0x44, 0xee, 0x7f, 0xce, 0x79, 0x1a, 0xc7), ExclusiveTo(typeof(UserInformation))]
    internal interface IUserInformationStatics
    {
        event Windows.Foundation.EventHandler<object> AccountPictureChanged;

        IStorageFile GetAccountPicture([In] AccountPictureKind kind);
        IAsyncOperation<string> GetDomainNameAsync();
        IAsyncOperation<string> GetPrincipalNameAsync();
        IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();
        IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync([In] IStorageFile image);
        IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync([In] IRandomAccessStream image);
        IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync([In] IStorageFile smallImage, [In] IStorageFile largImage, [In] IStorageFile video);
        IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync([In] IRandomAccessStream smallImage, [In] IRandomAccessStream largeImage, [In] IRandomAccessStream video);

        bool AccountPictureChangeEnabled { get; }

        string DisplayName { get; }

        string FirstName { get; }

        string LastName { get; }

        bool NameAccessAllowed { get; }
    }
}

