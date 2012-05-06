namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MobileBroadbandAccountEventArgs)), Version(0x6020000), Guid(0x3853c880, 0x77de, 0x4c04, 190, 0xad, 0xa1, 0x23, 0xb0, 140, 0x9f, 0x59)]
    internal interface IMobileBroadbandAccountEventArgs
    {
        string NetworkAccountId { get; }
    }
}

