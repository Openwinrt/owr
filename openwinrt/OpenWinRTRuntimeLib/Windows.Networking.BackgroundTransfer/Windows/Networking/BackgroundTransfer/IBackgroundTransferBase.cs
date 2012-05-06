namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Security.Credentials;

    [Windows.Foundation.Metadata.Guid(0x2a9da250, 0xc769, 0x458c, 0xaf, 0xe8, 0xfe, 0xb8, 0xd4, 0xd3, 0xb2, 0xef), Version(0x6020000)]
    public interface IBackgroundTransferBase
    {
        void SetRequestHeader([In] string headerName, [In] string headerValue);

        BackgroundTransferCostPolicy CostPolicy { get; [param: In] set; }

        string Group { get; [param: In] set; }

        string Method { get; [param: In] set; }

        PasswordCredential ProxyCredential { get; [param: In] set; }

        PasswordCredential ServerCredential { get; [param: In] set; }
    }
}

