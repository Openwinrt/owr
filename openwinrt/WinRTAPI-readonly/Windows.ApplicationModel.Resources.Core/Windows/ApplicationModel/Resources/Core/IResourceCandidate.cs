namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xaf5207d9, 0xc433, 0x4764, 0xb3, 0xfd, 0x8f, 0xa6, 0xbf, 0xbc, 0xba, 220), ExclusiveTo(typeof(ResourceCandidate))]
    internal interface IResourceCandidate
    {
        string GetQualifierValue([In] string qualifierName);
        IAsyncOperation<StorageFile> ToFileAsync();
        string ToString();

        bool IsDefault { get; }

        bool IsMatch { get; }

        bool IsMatchAsDefault { get; }

        IVectorView<ResourceQualifier> Qualifiers { get; }
    }
}

