namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Activatable(typeof(ITimeTriggerFactory), 0x6020000)]
    public sealed class TimeTrigger : ITimeTrigger, IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TimeTrigger([In] uint freshnessTime, [In] bool oneShot);

        public uint FreshnessTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Background.ITimeTrigger.FreshnessTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Background.ITimeTrigger.OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

