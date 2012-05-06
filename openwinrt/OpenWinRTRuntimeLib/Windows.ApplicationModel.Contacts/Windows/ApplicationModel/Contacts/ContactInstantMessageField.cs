namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IContactInstantMessageFieldFactory), 0x6020000), Version(0x6020000)]
    public sealed class ContactInstantMessageField : IContactInstantMessageField, IContactField
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactInstantMessageField([In] string userName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactInstantMessageField([In] string userName, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactInstantMessageField([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);

        public ContactFieldCategory Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri LaunchUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Service { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldCategory Windows.ApplicationModel.Contacts.IContactField.Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Windows.ApplicationModel.Contacts.IContactField.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactInstantMessageField.DisplayText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.ApplicationModel.Contacts.IContactInstantMessageField.LaunchUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactInstantMessageField.Service { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactInstantMessageField.UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

