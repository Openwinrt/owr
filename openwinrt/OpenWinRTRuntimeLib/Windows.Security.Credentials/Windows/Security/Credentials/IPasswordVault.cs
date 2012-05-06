namespace Windows.Security.Credentials
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PasswordVault)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x61fd2c0b, 0xc8d4, 0x48c1, 0xa5, 0x4f, 0xbc, 90, 100, 0x20, 90, 0xf2)]
    internal interface IPasswordVault
    {
        void Add([In] PasswordCredential credential);
        IVectorView<PasswordCredential> FindAllByResource([In] string resource);
        IVectorView<PasswordCredential> FindAllByUserName([In] string userName);
        void Remove([In] PasswordCredential credential);
        PasswordCredential Retrieve([In] string resource, [In] string userName);
        IVectorView<PasswordCredential> RetrieveAll();
    }
}

