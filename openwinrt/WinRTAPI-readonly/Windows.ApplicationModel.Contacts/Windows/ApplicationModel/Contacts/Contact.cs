namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class Contact : IContact
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Contact();

        public IVector<IContactField> Fields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IRandomAccessStreamReference Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IContactField> Windows.ApplicationModel.Contacts.IContact.Fields { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.IContact.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IRandomAccessStreamReference Windows.ApplicationModel.Contacts.IContact.Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

