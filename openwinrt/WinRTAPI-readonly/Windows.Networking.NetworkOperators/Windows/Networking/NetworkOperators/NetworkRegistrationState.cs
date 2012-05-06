namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum NetworkRegistrationState
    {
        None,
        Deregistered,
        Searching,
        Home,
        Roaming,
        Partner,
        Denied
    }
}

