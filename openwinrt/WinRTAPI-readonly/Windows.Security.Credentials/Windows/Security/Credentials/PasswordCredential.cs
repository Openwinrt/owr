namespace Windows.Security.Credentials
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(typeof(ICredentialFactory), 0x6020000)]
    public sealed class PasswordCredential : IPasswordCredential
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordCredential();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordCredential([In] string resource, [In] string userName, [In] string password);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RetrievePassword();

        public string Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Resource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Security.Credentials.IPasswordCredential.Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IPropertySet Windows.Security.Credentials.IPasswordCredential.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Credentials.IPasswordCredential.Resource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Security.Credentials.IPasswordCredential.UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

