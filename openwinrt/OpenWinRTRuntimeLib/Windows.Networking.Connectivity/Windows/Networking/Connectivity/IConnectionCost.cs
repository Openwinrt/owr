namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ConnectionCost)), Guid(0xbad7d829, 0x3416, 0x4b10, 0xa2, 2, 0xba, 0xc0, 0xb0, 0x75, 0xbd, 0xae)]
    internal interface IConnectionCost
    {
        bool ApproachingDataLimit { get; }

        Windows.Networking.Connectivity.NetworkCostType NetworkCostType { get; }

        bool OverDataLimit { get; }

        bool Roaming { get; }
    }
}

