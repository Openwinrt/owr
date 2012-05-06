namespace Windows.ApplicationModel.Contacts
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum ContactFieldType
    {
        Email,
        PhoneNumber,
        Location,
        InstantMessage,
        Custom
    }
}

