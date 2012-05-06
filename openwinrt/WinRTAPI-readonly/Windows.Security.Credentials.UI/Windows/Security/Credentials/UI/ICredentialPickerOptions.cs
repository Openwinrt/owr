namespace Windows.Security.Credentials.UI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(CredentialPickerOptions)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x965a0b4c, 0x95fa, 0x467f, 0x99, 0x2b, 11, 0x22, 0xe5, 0x85, 0x9b, 0xf6)]
    internal interface ICredentialPickerOptions
    {
        bool AlwaysDisplayDialog { get; [param: In] set; }

        Windows.Security.Credentials.UI.AuthenticationProtocol AuthenticationProtocol { get; [param: In] set; }

        bool CallerSavesCredential { get; [param: In] set; }

        string Caption { get; [param: In] set; }

        Windows.Security.Credentials.UI.CredentialSaveOption CredentialSaveOption { get; [param: In] set; }

        string CustomAuthenticationProtocol { get; [param: In] set; }

        uint ErrorCode { get; [param: In] set; }

        string Message { get; [param: In] set; }

        IBuffer PreviousCredential { get; [param: In] set; }

        string TargetName { get; [param: In] set; }
    }
}

