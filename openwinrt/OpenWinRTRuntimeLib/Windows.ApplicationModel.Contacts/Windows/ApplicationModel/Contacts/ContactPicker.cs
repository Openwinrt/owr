namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000)]
    public sealed class ContactPicker : IContactPicker
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContactPicker();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ContactInformation> PickSingleContactAsync();

        public string CommitButtonText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> DesiredFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactSelectionMode SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.Contacts.IContactPicker.CommitButtonText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.ApplicationModel.Contacts.IContactPicker.DesiredFields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ContactSelectionMode Windows.ApplicationModel.Contacts.IContactPicker.SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

