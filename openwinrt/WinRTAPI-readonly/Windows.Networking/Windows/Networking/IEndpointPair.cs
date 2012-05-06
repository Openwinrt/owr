namespace Windows.Networking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x33a0aa36, 0xf8fa, 0x4b30, 0xb8, 0x56, 0x76, 0x51, 0x7c, 0x3b, 0xd0, 0x6d), ExclusiveTo(typeof(EndpointPair))]
    internal interface IEndpointPair
    {
        HostName LocalHostName { get; [param: In] set; }

        string LocalServiceName { get; [param: In] set; }

        HostName RemoteHostName { get; [param: In] set; }

        string RemoteServiceName { get; [param: In] set; }
    }
}

