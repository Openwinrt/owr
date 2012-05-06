namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000)]
    public sealed class ContactFieldFactory : IContactFieldFactory, IContactLocationFieldFactory, IContactInstantMessageFieldFactory
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactFieldFactory();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateField_Default")]
        public ContactField CreateField([In] string value, [In] ContactFieldType type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateField_Category")]
        public ContactField CreateField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateField_Custom")]
        public ContactField CreateField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateInstantMessage_Default")]
        public ContactInstantMessageField CreateInstantMessage([In] string userName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateInstantMessage_Category")]
        public ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateInstantMessage_All")]
        public ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateLocation_Default")]
        public ContactLocationField CreateLocation([In] string unstructuredAddress);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateLocation_Category")]
        public ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateLocation_All")]
        public ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);
    }
}

