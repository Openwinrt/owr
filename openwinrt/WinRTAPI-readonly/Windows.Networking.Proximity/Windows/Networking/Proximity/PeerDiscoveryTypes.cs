namespace Windows.Networking.Proximity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum PeerDiscoveryTypes : uint
    {
        Browse = 1,
        None = 0,
        Triggered = 2
    }
}

