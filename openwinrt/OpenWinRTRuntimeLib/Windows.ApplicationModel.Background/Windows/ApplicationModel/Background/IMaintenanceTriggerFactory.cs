namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4b3ddb2e, 0x97dd, 0x4629, 0x88, 0xb0, 0xb0, 0x6c, 0xf9, 0x48, 0x2a, 0xe5), ExclusiveTo(typeof(MaintenanceTrigger)), Version(0x6020000)]
    internal interface IMaintenanceTriggerFactory
    {
        MaintenanceTrigger Create([In] uint freshnessTime, [In] bool oneShot);
    }
}

