namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ComponentLoadFailedEventArgs : IComponentLoadFailedEventArgs
    {
        public MediaProtectionServiceCompletion Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RevocationAndRenewalInformation Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaProtectionServiceCompletion Windows.Media.Protection.IComponentLoadFailedEventArgs.Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RevocationAndRenewalInformation Windows.Media.Protection.IComponentLoadFailedEventArgs.Information { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

