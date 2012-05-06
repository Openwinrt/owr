namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IContactFieldFactory), 0x6020000), Version(0x6020000)]
    public sealed class ContactField : IContactField
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactField([In] string value, [In] ContactFieldType type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);

        public ContactFieldCategory Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldCategory Windows.ApplicationModel.Contacts.IContactField.Category { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactFieldType Windows.ApplicationModel.Contacts.IContactField.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContactField.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

