namespace Windows.ApplicationModel.Activation
{
    using Windows.ApplicationModel.Contacts.Provider;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xce57aae7, 0x6449, 0x45a7, 0x97, 0x1f, 0xd1, 0x13, 190, 0x7a, 0x89, 0x36)]
    public interface IContactPickerActivatedEventArgs : IActivatedEventArgs
    {
        Windows.ApplicationModel.Contacts.Provider.ContactPickerUI ContactPickerUI { get; }
    }
}

