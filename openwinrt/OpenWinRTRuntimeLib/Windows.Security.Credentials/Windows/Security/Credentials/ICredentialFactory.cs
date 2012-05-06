namespace Windows.Security.Credentials
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x54ef13a1, 0xbf26, 0x47b5, 0x97, 0xdd, 0xde, 0x77, 0x9b, 0x7c, 0xad, 0x58)]
    public interface ICredentialFactory
    {
        PasswordCredential CreatePasswordCredential([In] string resource, [In] string userName, [In] string password);
    }
}

