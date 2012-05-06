namespace Windows.Networking.Connectivity
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DataPlanStatus)), Guid(0x977a8b8c, 0x3885, 0x40f3, 0x88, 0x51, 0x42, 0xcd, 0x2b, 0xd5, 0x68, 0xbb)]
    internal interface IDataPlanStatus
    {
        IReference<uint> DataLimitInMegabytes { get; }

        Windows.Networking.Connectivity.DataPlanUsage DataPlanUsage { get; }

        IReference<ulong> InboundBitsPerSecond { get; }

        IReference<uint> MaxTransferSizeInMegabytes { get; }

        IReference<DateTime> NextBillingCycle { get; }

        IReference<ulong> OutboundBitsPerSecond { get; }
    }
}

