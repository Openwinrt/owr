namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ConnectionCost : IConnectionCost
    {
        public bool ApproachingDataLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkCostType NetworkCostType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool OverDataLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Roaming { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.Connectivity.IConnectionCost.ApproachingDataLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkCostType Windows.Networking.Connectivity.IConnectionCost.NetworkCostType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.Connectivity.IConnectionCost.OverDataLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.Connectivity.IConnectionCost.Roaming { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

