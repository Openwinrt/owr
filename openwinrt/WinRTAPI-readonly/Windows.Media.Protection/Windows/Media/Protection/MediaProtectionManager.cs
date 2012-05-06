namespace Windows.Media.Protection
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.MTA), Version(0x6020000)]
    public sealed class MediaProtectionManager : IMediaProtectionManager
    {
        public event ComponentLoadFailedEventHandler ComponentLoadFailed;

        public event RebootNeededEventHandler RebootNeeded;

        public event ServiceRequestedEventHandler ServiceRequested;

        public event ComponentLoadFailedEventHandler Windows.Media.Protection.IMediaProtectionManager.ComponentLoadFailed;

        public event RebootNeededEventHandler Windows.Media.Protection.IMediaProtectionManager.RebootNeeded;

        public event ServiceRequestedEventHandler Windows.Media.Protection.IMediaProtectionManager.ServiceRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaProtectionManager();

        public IPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPropertySet Windows.Media.Protection.IMediaProtectionManager.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

