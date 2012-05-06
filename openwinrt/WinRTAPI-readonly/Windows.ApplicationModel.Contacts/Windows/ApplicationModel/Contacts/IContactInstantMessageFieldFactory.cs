namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xba0b6794, 0x91a3, 0x4bb2, 0xb1, 0xb9, 0x69, 0xa5, 0xdf, 240, 0xba, 9), Version(0x6020000)]
    public interface IContactInstantMessageFieldFactory
    {
        [Overload("CreateInstantMessage_Default")]
        ContactInstantMessageField CreateInstantMessage([In] string userName);
        [Overload("CreateInstantMessage_Category")]
        ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category);
        [Overload("CreateInstantMessage_All")]
        ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);
    }
}

