namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IKeyDerivationParametersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000)]
    public sealed class KeyDerivationParameters : IKeyDerivationParameters
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static KeyDerivationParameters BuildForPbkdf2([In] IBuffer pbkdf2Salt, [In] uint iterationCount);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static KeyDerivationParameters BuildForSP800108([In] IBuffer label, [In] IBuffer context);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static KeyDerivationParameters BuildForSP80056a([In] IBuffer algorithmId, [In] IBuffer partyUInfo, [In] IBuffer partyVInfo, [In] IBuffer suppPubInfo, [In] IBuffer suppPrivInfo);

        public uint IterationCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer KdfGenericBinary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Security.Cryptography.Core.IKeyDerivationParameters.IterationCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.Security.Cryptography.Core.IKeyDerivationParameters.KdfGenericBinary { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

