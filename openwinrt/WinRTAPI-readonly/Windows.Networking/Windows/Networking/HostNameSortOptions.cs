namespace Windows.Networking
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum HostNameSortOptions : uint
    {
        None = 0,
        OptimizeForLongConnections = 2
    }
}

