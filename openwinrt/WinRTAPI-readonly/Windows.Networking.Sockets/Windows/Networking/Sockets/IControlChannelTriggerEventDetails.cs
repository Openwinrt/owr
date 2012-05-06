namespace Windows.Networking.Sockets
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Guid(0x1b36e047, 0x89bb, 0x4236, 150, 0xac, 0x71, 0xd0, 0x12, 0xbb, 0x48, 0x69)]
    public interface IControlChannelTriggerEventDetails
    {
        Windows.Networking.Sockets.ControlChannelTrigger ControlChannelTrigger { get; }
    }
}

