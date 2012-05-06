namespace Windows.ApplicationModel.Contacts
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xcce33b37, 0xd85, 0x41fa, 180, 0x3d, 0xda, 0x59, 0x9c, 0x3e, 0xb0, 9), Version(0x6020000), ExclusiveTo(typeof(ContactInstantMessageField))]
    internal interface IContactInstantMessageField : IContactField
    {
        string DisplayText { get; }

        Uri LaunchUri { get; }

        string Service { get; }

        string UserName { get; }
    }
}

