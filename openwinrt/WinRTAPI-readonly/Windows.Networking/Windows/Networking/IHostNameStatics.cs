namespace Windows.Networking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(HostName)), Windows.Foundation.Metadata.Guid(0xf68cd4bf, 0xa388, 0x4e8b, 0x91, 0xea, 0x54, 0xdd, 0x6d, 0xd9, 1, 0xc0)]
    internal interface IHostNameStatics
    {
        int Compare([In] string value1, [In] string value2);
    }
}

