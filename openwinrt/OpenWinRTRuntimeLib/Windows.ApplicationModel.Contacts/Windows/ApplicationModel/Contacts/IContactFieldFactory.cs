namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x85e2913f, 0xe4a, 0x4a3e, 0x89, 0x94, 0x40, 0x6a, 0xe7, 0xed, 100, 110)]
    public interface IContactFieldFactory
    {
        [Overload("CreateField_Default")]
        ContactField CreateField([In] string value, [In] ContactFieldType type);
        [Overload("CreateField_Category")]
        ContactField CreateField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
        [Overload("CreateField_Custom")]
        ContactField CreateField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
    }
}

