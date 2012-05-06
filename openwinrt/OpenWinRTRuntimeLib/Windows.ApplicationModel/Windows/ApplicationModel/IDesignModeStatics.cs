namespace Windows.ApplicationModel
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x2c3893cc, 0xf81a, 0x4e7a, 0xb8, 0x57, 0x76, 0xa8, 8, 0x87, 0xe1, 0x85), ExclusiveTo(typeof(DesignMode))]
    internal interface IDesignModeStatics
    {
        bool DesignModeEnabled { get; }
    }
}

