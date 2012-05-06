namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Background;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x7d1431a7, 0xee96, 0x40e8, 0xa1, 0x99, 0x87, 3, 0xcd, 150, 0x9e, 0xc3), Version(0x6020000), ExclusiveTo(typeof(ControlChannelTrigger)), WebHostHidden]
    internal interface IControlChannelTrigger : IClosable
    {
        void DecreaseNetworkKeepAliveInterval();
        void FlushTransport();
        void UsingTransport([In] object transport);
        ControlChannelTriggerStatus WaitForPushEnabled();

        string ControlChannelTriggerId { get; }

        uint CurrentKeepAliveIntervalInMinutes { get; }

        IBackgroundTrigger KeepAliveTrigger { get; }

        IBackgroundTrigger PushNotificationTrigger { get; }

        uint ServerKeepAliveIntervalInMinutes { get; [param: In] set; }

        object TransportObject { get; }
    }
}

