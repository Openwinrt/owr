namespace Windows.Networking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Networking.Connectivity;

    [Static(typeof(IHostNameStatics), 0x6020000), Activatable(typeof(IHostNameFactory), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class HostName : IHostName
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public HostName([In] string hostName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int Compare([In] string value1, [In] string value2);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsEqual([In] HostName hostName);

        public string CanonicalName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RawName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.IHostName.CanonicalName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.IHostName.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Networking.Connectivity.NetworkAdapter Windows.Networking.IHostName.NetworkAdapter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.IHostName.RawName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

