namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class DataPlanUsage : IDataPlanUsage
    {
        public Windows.Foundation.DateTime LastSyncTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MegabytesUsed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.Networking.Connectivity.IDataPlanUsage.LastSyncTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.Connectivity.IDataPlanUsage.MegabytesUsed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

