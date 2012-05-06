namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ServiceRequestedEventArgs : IServiceRequestedEventArgs
    {
        public MediaProtectionServiceCompletion Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMediaProtectionServiceRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaProtectionServiceCompletion Windows.Media.Protection.IServiceRequestedEventArgs.Completion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMediaProtectionServiceRequest Windows.Media.Protection.IServiceRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

