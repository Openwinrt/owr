namespace Windows.ApplicationModel.Contacts.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Contacts;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ContactPickerUI)), Windows.Foundation.Metadata.Guid(0xe2cc1366, 0xcf66, 0x43c4, 0xa9, 0x6a, 0xa5, 0xa1, 0x12, 0xdb, 0x47, 70), Version(0x6020000)]
    internal interface IContactPickerUI
    {
        event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;

        AddContactResult AddContact([In] string id, [In] Contact contact);
        bool ContainsContact([In] string id);
        void RemoveContact([In] string id);

        IVectorView<string> DesiredFields { get; }

        ContactSelectionMode SelectionMode { get; }
    }
}

