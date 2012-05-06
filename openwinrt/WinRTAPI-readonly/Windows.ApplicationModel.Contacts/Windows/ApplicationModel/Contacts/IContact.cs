namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xec0072f3, 0x2118, 0x4049, 0x9e, 0xbc, 0x17, 240, 0xab, 0x69, 0x2b, 100), ExclusiveTo(typeof(Contact))]
    internal interface IContact
    {
        IVector<IContactField> Fields { get; }

        string Name { get; [param: In] set; }

        IRandomAccessStreamReference Thumbnail { get; [param: In] set; }
    }
}

