namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(KnownContactField)), Windows.Foundation.Metadata.Guid(0x2e0e1b12, 0xd627, 0x4fca, 0xba, 0xd4, 0x1f, 0xaf, 0x16, 140, 0x7d, 20)]
    internal interface IKnownContactFieldStatics
    {
        ContactFieldType ConvertNameToType([In] string name);
        string ConvertTypeToName([In] ContactFieldType type);

        string Email { get; }

        string InstantMessage { get; }

        string Location { get; }

        string PhoneNumber { get; }
    }
}

