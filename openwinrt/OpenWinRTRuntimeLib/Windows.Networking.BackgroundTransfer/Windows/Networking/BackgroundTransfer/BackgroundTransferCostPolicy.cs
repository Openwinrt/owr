namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum BackgroundTransferCostPolicy
    {
        AvoidNetworkCharges,
        AcceptNetworkCharges
    }
}

