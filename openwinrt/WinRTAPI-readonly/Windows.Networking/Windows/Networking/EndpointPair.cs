namespace Windows.Networking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.MTA), DualApiPartition(version=0x6020000), Activatable(typeof(IEndpointPairFactory), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class EndpointPair : IEndpointPair
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EndpointPair();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EndpointPair([In] HostName localHostName, [In] string localServiceName, [In] HostName remoteHostName, [In] string remoteServiceName);

        public HostName LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public HostName RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public HostName Windows.Networking.IEndpointPair.LocalHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.IEndpointPair.LocalServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public HostName Windows.Networking.IEndpointPair.RemoteHostName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Networking.IEndpointPair.RemoteServiceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

