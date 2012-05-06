namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ContactInformation : IContactInformation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<ContactField> QueryCustomFields([In] string customName);

        public IVectorView<ContactField> CustomFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactField> Emails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactInstantMessageField> InstantMessages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactLocationField> Locations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactField> PhoneNumbers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactField> Windows.ApplicationModel.Contacts.IContactInformation.CustomFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactField> Windows.ApplicationModel.Contacts.IContactInformation.Emails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactInstantMessageField> Windows.ApplicationModel.Contacts.IContactInformation.InstantMessages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactLocationField> Windows.ApplicationModel.Contacts.IContactInformation.Locations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactInformation.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<ContactField> Windows.ApplicationModel.Contacts.IContactInformation.PhoneNumbers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

