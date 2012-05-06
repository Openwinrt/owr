namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x45694947, 0xc741, 0x434b, 0xa7, 0x9e, 0x47, 0x4c, 0x12, 0xd9, 0x3d, 0x2f), ExclusiveTo(typeof(MediaProtectionManager)), Version(0x6020000)]
    internal interface IMediaProtectionManager
    {
        event ComponentLoadFailedEventHandler ComponentLoadFailed;

        event RebootNeededEventHandler RebootNeeded;

        event ServiceRequestedEventHandler ServiceRequested;

        IPropertySet Properties { get; }
    }
}

