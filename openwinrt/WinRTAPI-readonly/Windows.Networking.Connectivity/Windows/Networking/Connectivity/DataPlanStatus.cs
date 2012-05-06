namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DataPlanStatus : IDataPlanStatus
    {
        public IReference<uint> DataLimitInMegabytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.DataPlanUsage DataPlanUsage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<ulong> InboundBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<uint> MaxTransferSizeInMegabytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> NextBillingCycle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<ulong> OutboundBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<uint> Windows.Networking.Connectivity.IDataPlanStatus.DataLimitInMegabytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.DataPlanUsage Windows.Networking.Connectivity.IDataPlanStatus.DataPlanUsage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<ulong> Windows.Networking.Connectivity.IDataPlanStatus.InboundBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<uint> Windows.Networking.Connectivity.IDataPlanStatus.MaxTransferSizeInMegabytes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Windows.Foundation.DateTime> Windows.Networking.Connectivity.IDataPlanStatus.NextBillingCycle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<ulong> Windows.Networking.Connectivity.IDataPlanStatus.OutboundBitsPerSecond { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

