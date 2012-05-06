namespace Windows.Security.Credentials.UI
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(CredentialPickerResults)), Guid(0x1948f99a, 0xcc30, 0x410c, 0x9c, 0x38, 0xcc, 8, 0x84, 0xc5, 0xb3, 0xd7)]
    internal interface ICredentialPickerResults
    {
        IBuffer Credential { get; }

        string CredentialDomainName { get; }

        string CredentialPassword { get; }

        bool CredentialSaved { get; }

        Windows.Security.Credentials.UI.CredentialSaveOption CredentialSaveOption { get; }

        string CredentialUserName { get; }

        uint ErrorCode { get; }
    }
}

