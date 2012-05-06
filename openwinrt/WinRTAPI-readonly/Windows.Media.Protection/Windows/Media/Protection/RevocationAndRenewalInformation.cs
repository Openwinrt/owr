namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class RevocationAndRenewalInformation : IRevocationAndRenewalInformation
    {
        public IVector<RevocationAndRenewalItem> Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<RevocationAndRenewalItem> Windows.Media.Protection.IRevocationAndRenewalInformation.Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

