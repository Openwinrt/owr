namespace Windows.Networking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(EndpointPair)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb609d971, 0x64e0, 0x442b, 170, 0x6f, 0xcc, 140, 0x8f, 0x18, 0x1f, 120)]
    internal interface IEndpointPairFactory
    {
        EndpointPair CreateEndpointPair([In] HostName localHostName, [In] string localServiceName, [In] HostName remoteHostName, [In] string remoteServiceName);
    }
}

