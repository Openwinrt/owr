namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IContactLocationFieldFactory), 0x6020000), Version(0x6020000)]
    public sealed class ContactLocationField : IContactLocationField, IContactField
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactLocationField([In] string unstructuredAddress);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactLocationField([In] string unstructuredAddress, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactLocationField([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);

        public ContactFieldCategory Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string City { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Country { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string PostalCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Region { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Street { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UnstructuredAddress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldCategory Windows.ApplicationModel.Contacts.IContactField.Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Windows.ApplicationModel.Contacts.IContactField.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.City { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.Country { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.PostalCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.Region { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.Street { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactLocationField.UnstructuredAddress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

