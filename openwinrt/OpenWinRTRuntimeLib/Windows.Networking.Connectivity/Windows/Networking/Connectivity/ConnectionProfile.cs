namespace Windows.Networking.Connectivity
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ConnectionProfile : IConnectionProfile
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ConnectionCost GetConnectionCost();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataPlanStatus GetDataPlanStatus();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetLocalUsage"), DefaultOverload]
        public DataUsage GetLocalUsage([In] Windows.Foundation.DateTime StartTime, [In] Windows.Foundation.DateTime EndTime);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetLocalUsagePerRoamingStates"), DefaultOverload]
        public DataUsage GetLocalUsage([In] Windows.Foundation.DateTime StartTime, [In] Windows.Foundation.DateTime EndTime, [In] RoamingStates States);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NetworkConnectivityLevel GetNetworkConnectivityLevel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<string> GetNetworkNames();

        public Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ProfileName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter Windows.Networking.Connectivity.IConnectionProfile.NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.Connectivity.IConnectionProfile.ProfileName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

