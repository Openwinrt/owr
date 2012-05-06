namespace Windows.Networking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x458c23ed, 0x712f, 0x4576, 0xad, 0xf1, 0xc2, 11, 0x2c, 100, 0x35, 0x58), ExclusiveTo(typeof(HostName))]
    internal interface IHostNameFactory
    {
        HostName CreateHostName([In] string hostName);
    }
}

