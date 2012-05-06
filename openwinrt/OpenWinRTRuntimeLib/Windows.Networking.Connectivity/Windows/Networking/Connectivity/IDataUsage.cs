namespace Windows.Networking.Connectivity
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DataUsage)), Guid(0xc1431dd3, 0xb146, 0x4d39, 0xb9, 0x59, 12, 0x69, 0xb0, 150, 0xc5, 0x12)]
    internal interface IDataUsage
    {
        ulong BytesReceived { get; }

        ulong BytesSent { get; }
    }
}

