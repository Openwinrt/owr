namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf79932d7, 0x2fdf, 0x43fe, 0x8f, 0x18, 0x41, 0x89, 0x73, 0x90, 0xbc, 0xfe), Version(0x6020000)]
    public interface IContactLocationFieldFactory
    {
        [Overload("CreateLocation_Default")]
        ContactLocationField CreateLocation([In] string unstructuredAddress);
        [Overload("CreateLocation_Category")]
        ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category);
        [Overload("CreateLocation_All")]
        ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);
    }
}

