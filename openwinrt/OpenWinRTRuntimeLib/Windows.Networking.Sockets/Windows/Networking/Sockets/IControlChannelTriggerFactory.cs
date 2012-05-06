namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xda4b7cf0, 0x8d71, 0x446f, 0x88, 0xc3, 0xb9, 0x51, 0x84, 0xa2, 0xd6, 0xcd), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ControlChannelTrigger))]
    internal interface IControlChannelTriggerFactory
    {
        [Overload("CreateControlChannelTrigger")]
        ControlChannelTrigger CreateControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes);
        [Overload("CreateControlChannelTriggerEx")]
        ControlChannelTrigger CreateControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes, [In] ControlChannelTriggerResourceType resourceRequestType);
    }
}

