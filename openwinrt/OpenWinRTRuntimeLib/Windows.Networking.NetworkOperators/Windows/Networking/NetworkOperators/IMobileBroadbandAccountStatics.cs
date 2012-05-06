namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xaa7f4d24, 0xafc1, 0x4fc8, 0xae, 0x9a, 0xa9, 0x17, 0x53, 0x10, 250, 0xad), Version(0x6020000), ExclusiveTo(typeof(MobileBroadbandAccount))]
    internal interface IMobileBroadbandAccountStatics
    {
        MobileBroadbandAccount CreateFromNetworkAccountId([In] string networkAccountId);

        IVectorView<string> AvailableNetworkAccountIds { get; }
    }
}

