namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ContactInformation)), Windows.Foundation.Metadata.Guid(0x275eb6d4, 0x6a2e, 0x4278, 0xa9, 20, 0xe4, 0x60, 0xd5, 240, 0x88, 0xf6)]
    internal interface IContactInformation
    {
        IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();
        IVectorView<ContactField> QueryCustomFields([In] string customName);

        IVectorView<ContactField> CustomFields { get; }

        IVectorView<ContactField> Emails { get; }

        IVectorView<ContactInstantMessageField> InstantMessages { get; }

        IVectorView<ContactLocationField> Locations { get; }

        string Name { get; }

        IVectorView<ContactField> PhoneNumbers { get; }
    }
}

