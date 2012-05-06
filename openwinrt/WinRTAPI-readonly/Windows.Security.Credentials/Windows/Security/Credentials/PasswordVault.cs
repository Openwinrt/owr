namespace Windows.Security.Credentials
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Activatable(0x6020000)]
    public sealed class PasswordVault : IPasswordVault
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordVault();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Add([In] PasswordCredential credential);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<PasswordCredential> FindAllByResource([In] string resource);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<PasswordCredential> FindAllByUserName([In] string userName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] PasswordCredential credential);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PasswordCredential Retrieve([In] string resource, [In] string userName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<PasswordCredential> RetrieveAll();
    }
}

