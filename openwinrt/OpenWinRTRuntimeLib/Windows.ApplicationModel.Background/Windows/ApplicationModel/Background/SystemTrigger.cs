namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Activatable(typeof(ISystemTriggerFactory), 0x6020000), Version(0x6020000)]
    public sealed class SystemTrigger : ISystemTrigger, IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SystemTrigger([In] SystemTriggerType triggerType, [In] bool oneShot);

        public bool OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SystemTriggerType TriggerType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Background.ISystemTrigger.OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SystemTriggerType Windows.ApplicationModel.Background.ISystemTrigger.TriggerType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

