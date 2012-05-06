namespace Windows.ApplicationModel.Contacts
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9ec00f82, 0xab6e, 0x4b36, 0x89, 0xe3, 0xb2, 0x3b, 0xc0, 0xa1, 0xda, 0xcc), ExclusiveTo(typeof(ContactLocationField))]
    internal interface IContactLocationField : IContactField
    {
        string City { get; }

        string Country { get; }

        string PostalCode { get; }

        string Region { get; }

        string Street { get; }

        string UnstructuredAddress { get; }
    }
}

