namespace Windows.ApplicationModel.Contacts.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ContactRemovedEventArgs : IContactRemovedEventArgs
    {
        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Contacts.Provider.IContactRemovedEventArgs.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

