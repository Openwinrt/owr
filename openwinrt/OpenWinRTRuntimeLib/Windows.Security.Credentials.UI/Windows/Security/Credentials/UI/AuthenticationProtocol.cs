namespace Windows.Security.Credentials.UI
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum AuthenticationProtocol
    {
        Basic,
        Digest,
        Ntlm,
        Kerberos,
        Negotiate,
        TerminalServices,
        Custom
    }
}

