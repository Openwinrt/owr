namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum RoamingStates : uint
    {
        None = 0,
        NotRoaming = 1,
        Roaming = 2
    }
}

