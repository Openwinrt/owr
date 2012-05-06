namespace Windows.ApplicationModel.Contacts
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xb176486a, 0xd293, 0x492c, 160, 0x58, 0xdb, 0x57, 0x5b, 0x3e, 60, 15), Version(0x6020000)]
    public interface IContactField
    {
        ContactFieldCategory Category { get; }

        string Name { get; }

        ContactFieldType Type { get; }

        string Value { get; }
    }
}

