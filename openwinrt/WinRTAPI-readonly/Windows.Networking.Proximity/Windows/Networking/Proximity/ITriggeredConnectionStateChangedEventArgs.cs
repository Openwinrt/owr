namespace Windows.Networking.Proximity
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xc6a780ad, 0xf6e1, 0x4d54, 150, 0xe2, 0x33, 0xf6, 0x20, 0xbc, 0xa8, 0x8a), ExclusiveTo(typeof(TriggeredConnectionStateChangedEventArgs)), Version(0x6020000)]
    internal interface ITriggeredConnectionStateChangedEventArgs
    {
        uint Id { get; }

        ProximityStreamSocket Socket { get; }

        TriggeredConnectState State { get; }
    }
}

