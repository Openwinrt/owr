namespace Windows.Security.Credentials.UI
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class CredentialPickerResults : ICredentialPickerResults
    {
        public IBuffer Credential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CredentialDomainName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CredentialPassword { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CredentialSaved { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Security.Credentials.UI.CredentialSaveOption CredentialSaveOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CredentialUserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.Security.Credentials.UI.ICredentialPickerResults.Credential { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Credentials.UI.ICredentialPickerResults.CredentialDomainName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Credentials.UI.ICredentialPickerResults.CredentialPassword { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Security.Credentials.UI.ICredentialPickerResults.CredentialSaved { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Security.Credentials.UI.CredentialSaveOption Windows.Security.Credentials.UI.ICredentialPickerResults.CredentialSaveOption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.Credentials.UI.ICredentialPickerResults.CredentialUserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Security.Credentials.UI.ICredentialPickerResults.ErrorCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

