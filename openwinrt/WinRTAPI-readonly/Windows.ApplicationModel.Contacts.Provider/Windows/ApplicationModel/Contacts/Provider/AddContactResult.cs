namespace Windows.ApplicationModel.Contacts.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum AddContactResult
    {
        Added,
        AlreadyAdded,
        Unavailable
    }
}

