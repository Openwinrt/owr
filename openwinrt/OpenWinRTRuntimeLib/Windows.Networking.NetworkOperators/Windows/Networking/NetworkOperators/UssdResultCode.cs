namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum UssdResultCode
    {
        NoActionRequired,
        ActionRequired,
        Terminated,
        OtherLocalClient,
        OperationNotSupported,
        NetworkTimeout
    }
}

