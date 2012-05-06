namespace Windows.Devices.Enumeration.Pnp
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Static(typeof(IPnpObjectStatics), 0x6020000), Version(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both)]
    public sealed class PnpObject : IPnpObject
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<PnpObject> CreateFromIdAsync([In] PnpObjectType type, [In] string id, [In] IIterable<string> requestedProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcher"), DefaultOverload]
        public static PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWatcherAqsFilter"), DefaultOverload]
        public static PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("FindAllAsync")]
        public static IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("FindAllAsyncAqsFilter")]
        public static IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Update([In] PnpObjectUpdate updateInfo);

        public string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PnpObjectType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Devices.Enumeration.Pnp.IPnpObject.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, object> Windows.Devices.Enumeration.Pnp.IPnpObject.Properties { [return: HasVariant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PnpObjectType Windows.Devices.Enumeration.Pnp.IPnpObject.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

