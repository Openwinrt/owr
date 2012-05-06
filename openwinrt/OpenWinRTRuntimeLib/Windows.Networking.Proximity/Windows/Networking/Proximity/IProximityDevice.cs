namespace Windows.Networking.Proximity
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(ProximityDevice)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xefa8a552, 0xf6e1, 0x4329, 160, 0xfc, 0xab, 0x6b, 15, 210, 130, 0x62)]
    internal interface IProximityDevice
    {
        event DeviceArrivedEventHandler DeviceArrived;

        event DeviceDepartedEventHandler DeviceDeparted;

        [DefaultOverload, Overload("PublishBinaryMessage")]
        long PublishBinaryMessage([In] string messageType, [In] IBuffer message);
        [Overload("PublishBinaryMessageWithCallback"), DefaultOverload]
        long PublishBinaryMessage([In] string messageType, [In] IBuffer message, [In] MessageTransmittedHandler messageTransmittedHandler);
        [Overload("PublishMessage"), DefaultOverload]
        long PublishMessage([In] string messageType, [In] string message);
        [DefaultOverload, Overload("PublishMessageWithCallback")]
        long PublishMessage([In] string messageType, [In] string message, [In] MessageTransmittedHandler messageTransmittedHandler);
        [DefaultOverload, Overload("PublishUriMessage")]
        long PublishUriMessage([In] Uri message);
        [Overload("PublishUriMessageWithCallback"), DefaultOverload]
        long PublishUriMessage([In] Uri message, [In] MessageTransmittedHandler messageTransmittedHandler);
        void StopPublishingMessage([In] long messageId);
        void StopSubscribingForMessage([In] long subscriptionId);
        long SubscribeForMessage([In] string messageType, [In] MessageReceivedHandler messageReceivedHandler);

        ulong BitsPerSecond { get; }

        string DeviceId { get; }

        uint MaxMessageBytes { get; }
    }
}

