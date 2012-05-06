namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum NetworkTypes : uint
    {
        Internet = 1,
        None = 0,
        PrivateNetwork = 2
    }
}

