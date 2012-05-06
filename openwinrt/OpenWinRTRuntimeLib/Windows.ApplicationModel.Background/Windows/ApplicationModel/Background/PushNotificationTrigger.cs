namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.MTA), Activatable(0x6020000), Activatable(typeof(IPushNotificationTriggerFactory), 0x6020000)]
    public sealed class PushNotificationTrigger : IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PushNotificationTrigger();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PushNotificationTrigger([In] string applicationId);
    }
}

