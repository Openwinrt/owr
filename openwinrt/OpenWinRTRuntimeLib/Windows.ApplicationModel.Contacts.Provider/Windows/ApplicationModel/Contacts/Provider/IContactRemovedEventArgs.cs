namespace Windows.ApplicationModel.Contacts.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x6f354338, 0x3302, 0x4d13, 0xad, 0x8d, 0xad, 0xcc, 15, 0xf9, 0xe4, 0x7c), ExclusiveTo(typeof(ContactRemovedEventArgs))]
    internal interface IContactRemovedEventArgs
    {
        string Id { get; }
    }
}

