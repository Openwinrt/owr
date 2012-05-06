namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum NetworkCostType
    {
        Unknown,
        Unrestricted,
        Fixed,
        Variable
    }
}

