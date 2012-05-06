namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ContactPicker)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe09fd91, 0x42f8, 0x4055, 0x90, 160, 0x89, 0x6f, 150, 0x73, 0x89, 0x36)]
    internal interface IContactPicker
    {
        IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
        IAsyncOperation<ContactInformation> PickSingleContactAsync();

        string CommitButtonText { get; [param: In] set; }

        IVector<string> DesiredFields { get; }

        ContactSelectionMode SelectionMode { get; [param: In] set; }
    }
}

