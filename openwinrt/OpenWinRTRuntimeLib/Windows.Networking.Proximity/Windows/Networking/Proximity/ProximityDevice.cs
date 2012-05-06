namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Static(typeof(IProximityDeviceStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class ProximityDevice : IProximityDevice
    {
        public event DeviceArrivedEventHandler DeviceArrived;

        public event DeviceDepartedEventHandler DeviceDeparted;

        public event DeviceArrivedEventHandler Windows.Networking.Proximity.IProximityDevice.DeviceArrived;

        public event DeviceDepartedEventHandler Windows.Networking.Proximity.IProximityDevice.DeviceDeparted;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ProximityDevice FromId([In] string deviceInterfaceId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ProximityDevice GetDefault();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetDeviceSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("PublishBinaryMessage")]
        public long PublishBinaryMessage([In] string messageType, [In] IBuffer message);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PublishBinaryMessageWithCallback"), DefaultOverload]
        public long PublishBinaryMessage([In] string messageType, [In] IBuffer message, [In] MessageTransmittedHandler messageTransmittedHandler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("PublishMessage")]
        public long PublishMessage([In] string messageType, [In] string message);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("PublishMessageWithCallback")]
        public long PublishMessage([In] string messageType, [In] string message, [In] MessageTransmittedHandler messageTransmittedHandler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PublishUriMessage"), DefaultOverload]
        public long PublishUriMessage([In] Uri message);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PublishUriMessageWithCallback"), DefaultOverload]
        public long PublishUriMessage([In] Uri message, [In] MessageTransmittedHandler messageTransmittedHandler);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StopPublishingMessage([In] long messageId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StopSubscribingForMessage([In] long subscriptionId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public long SubscribeForMessage([In] string messageType, [In] MessageReceivedHandler messageReceivedHandler);

        public ulong BitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MaxMessageBytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ulong Windows.Networking.Proximity.IProximityDevice.BitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Proximity.IProximityDevice.DeviceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Proximity.IProximityDevice.MaxMessageBytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

