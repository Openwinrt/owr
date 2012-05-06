namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class RevocationAndRenewalItem : IRevocationAndRenewalItem
    {
        public string HeaderHash { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string PublicKeyHash { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RevocationAndRenewalReasons Reasons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RenewalId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Protection.IRevocationAndRenewalItem.HeaderHash { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Protection.IRevocationAndRenewalItem.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Protection.IRevocationAndRenewalItem.PublicKeyHash { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RevocationAndRenewalReasons Windows.Media.Protection.IRevocationAndRenewalItem.Reasons { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Media.Protection.IRevocationAndRenewalItem.RenewalId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

