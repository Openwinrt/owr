namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IMaintenanceTriggerFactory), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class MaintenanceTrigger : IMaintenanceTrigger, IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MaintenanceTrigger([In] uint freshnessTime, [In] bool oneShot);

        public uint FreshnessTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Background.IMaintenanceTrigger.FreshnessTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Background.IMaintenanceTrigger.OneShot { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

