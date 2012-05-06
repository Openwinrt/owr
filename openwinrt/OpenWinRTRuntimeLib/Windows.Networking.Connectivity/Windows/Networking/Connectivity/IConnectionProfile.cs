namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ConnectionProfile)), Windows.Foundation.Metadata.Guid(0x71ba143c, 0x598e, 0x49d0, 0x84, 0xeb, 0x8f, 0xeb, 0xae, 220, 0xc1, 0x95)]
    internal interface IConnectionProfile
    {
        ConnectionCost GetConnectionCost();
        DataPlanStatus GetDataPlanStatus();
        [DefaultOverload, Overload("GetLocalUsage")]
        DataUsage GetLocalUsage([In] Windows.Foundation.DateTime StartTime, [In] Windows.Foundation.DateTime EndTime);
        [Overload("GetLocalUsagePerRoamingStates"), DefaultOverload]
        DataUsage GetLocalUsage([In] Windows.Foundation.DateTime StartTime, [In] Windows.Foundation.DateTime EndTime, [In] RoamingStates States);
        NetworkConnectivityLevel GetNetworkConnectivityLevel();
        IVectorView<string> GetNetworkNames();

        Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { get; }

        string ProfileName { get; }
    }
}

