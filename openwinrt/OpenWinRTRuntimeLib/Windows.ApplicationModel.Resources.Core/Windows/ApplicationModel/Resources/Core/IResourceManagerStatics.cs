namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1cc0fdfc, 0x69ee, 0x4e43, 0x99, 1, 0x47, 0xf1, 0x26, 0x87, 0xba, 0xf7), ExclusiveTo(typeof(ResourceManager)), Version(0x6020000)]
    internal interface IResourceManagerStatics
    {
        bool IsResourceReference([In] string resourceReference);

        ResourceManager Current { get; }
    }
}

