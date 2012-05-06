namespace Windows.ApplicationModel.Contacts.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Contacts;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ContactPickerUI : IContactPickerUI
    {
        public event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;

        public event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> Windows.ApplicationModel.Contacts.Provider.IContactPickerUI.ContactRemoved;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AddContactResult AddContact([In] string id, [In] Contact contact);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool ContainsContact([In] string id);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveContact([In] string id);

        public IVectorView<string> DesiredFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactSelectionMode SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.ApplicationModel.Contacts.Provider.IContactPickerUI.DesiredFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactSelectionMode Windows.ApplicationModel.Contacts.Provider.IContactPickerUI.SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

