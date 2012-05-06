namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb3c32a3d, 0xd168, 0x4660, 0xbb, 0xf3, 0xa7, 0x33, 0xb1, 0x4b, 110, 1), Version(0x6020000), ExclusiveTo(typeof(PnpObject))]
    internal interface IPnpObjectStatics
    {
        IAsyncOperation<PnpObject> CreateFromIdAsync([In] PnpObjectType type, [In] string id, [In] IIterable<string> requestedProperties);
        [Overload("CreateWatcher"), DefaultOverload]
        PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
        [DefaultOverload, Overload("CreateWatcherAqsFilter")]
        PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
        [DefaultOverload, Overload("FindAllAsync")]
        IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
        [Overload("FindAllAsyncAqsFilter"), DefaultOverload]
        IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
    }
}

