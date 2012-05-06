namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2f9acf82, 0x2004, 0x4d5d, 0xbf, 0x81, 0x2a, 0xba, 0x1b, 0x4b, 0xe4, 0xa8), ExclusiveTo(typeof(UssdMessage))]
    internal interface IUssdMessage
    {
        byte[] GetPayload();
        void SetPayload([In, Range(0, 160)] byte[] value);

        byte DataCodingScheme { get; [param: In] set; }

        string PayloadAsText { get; [param: In] set; }
    }
}

