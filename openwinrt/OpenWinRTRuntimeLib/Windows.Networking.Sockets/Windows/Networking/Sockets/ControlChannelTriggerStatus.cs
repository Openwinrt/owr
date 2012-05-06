namespace Windows.Networking.Sockets
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum ControlChannelTriggerStatus
    {
        HardwareSlotRequested,
        SoftwareSlotAllocated,
        HardwareSlotAllocated,
        PolicyError,
        SystemError
    }
}

