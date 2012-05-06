namespace Windows.Management.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1e1862e3, 0x698e, 0x49a1, 0x97, 0x52, 0xde, 0xe9, 0x49, 0x25, 0xb9, 0xb3), ExclusiveTo(typeof(ApplicationDataManager))]
    internal interface IApplicationDataManagerStatics
    {
        ApplicationData CreateForPackageFamily([In] string packageFamilyName);
    }
}

