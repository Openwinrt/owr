namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x38c682fe, 0x9b54, 0x45e6, 0xb2, 0xf3, 0x26, 0x9b, 0x87, 0xa6, 0xf7, 0x34), ExclusiveTo(typeof(TimeTrigger))]
    internal interface ITimeTriggerFactory
    {
        TimeTrigger Create([In] uint freshnessTime, [In] bool oneShot);
    }
}

