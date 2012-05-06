namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DataPlanUsage)), Guid(0xb921492d, 0x3b44, 0x47ff, 0xb3, 0x61, 190, 0x59, 230, 0x9e, 0xd1, 0xb0)]
    internal interface IDataPlanUsage
    {
        Windows.Foundation.DateTime LastSyncTime { get; }

        uint MegabytesUsed { get; }
    }
}

