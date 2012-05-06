namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Background;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IControlChannelTriggerFactory), 0x6020000), Threading(ThreadingModel.MTA), WebHostHidden, Version(0x6020000)]
    public sealed class ControlChannelTrigger : IControlChannelTrigger, IClosable
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes, [In] ControlChannelTriggerResourceType resourceRequestType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void DecreaseNetworkKeepAliveInterval();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void FlushTransport();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void UsingTransport([In] object transport);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ControlChannelTriggerStatus WaitForPushEnabled();

        public string ControlChannelTriggerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint CurrentKeepAliveIntervalInMinutes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBackgroundTrigger KeepAliveTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBackgroundTrigger PushNotificationTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ServerKeepAliveIntervalInMinutes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object TransportObject { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Sockets.IControlChannelTrigger.ControlChannelTriggerId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Sockets.IControlChannelTrigger.CurrentKeepAliveIntervalInMinutes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBackgroundTrigger Windows.Networking.Sockets.IControlChannelTrigger.KeepAliveTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBackgroundTrigger Windows.Networking.Sockets.IControlChannelTrigger.PushNotificationTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Sockets.IControlChannelTrigger.ServerKeepAliveIntervalInMinutes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.Networking.Sockets.IControlChannelTrigger.TransportObject { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

