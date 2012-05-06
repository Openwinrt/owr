namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0xea961fbe, 0xf37f, 0x4146, 0x9d, 0xfe, 0xa4, 0x56, 0xf1, 0x73, 0x5f, 0x4b), ExclusiveTo(typeof(KeyDerivationParameters)), Version(0x6020000)]
    internal interface IKeyDerivationParametersStatics
    {
        KeyDerivationParameters BuildForPbkdf2([In] IBuffer pbkdf2Salt, [In] uint iterationCount);
        KeyDerivationParameters BuildForSP800108([In] IBuffer label, [In] IBuffer context);
        KeyDerivationParameters BuildForSP80056a([In] IBuffer algorithmId, [In] IBuffer partyUInfo, [In] IBuffer partyVInfo, [In] IBuffer suppPubInfo, [In] IBuffer suppPrivInfo);
    }
}

