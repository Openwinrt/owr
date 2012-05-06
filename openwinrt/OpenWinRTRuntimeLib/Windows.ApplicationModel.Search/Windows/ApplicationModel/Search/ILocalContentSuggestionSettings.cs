namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(LocalContentSuggestionSettings)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xeeaeb062, 0x743d, 0x456e, 0x84, 0xa3, 0x23, 240, 0x6f, 0x2d, 0x15, 0xd7)]
    internal interface ILocalContentSuggestionSettings
    {
        string AqsFilter { get; [param: In] set; }

        bool Enabled { get; [param: In] set; }

        IVector<StorageFolder> Locations { get; }

        IVector<string> PropertiesToMatch { get; }
    }
}

