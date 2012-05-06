namespace Windows.Devices.Enumeration
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(EnclosureLocation)), Guid(0x42340a27, 0x5810, 0x459c, 170, 0xbb, 0xc6, 0x5e, 0x1f, 0x81, 0x3e, 0xcf)]
    internal interface IEnclosureLocation
    {
        bool InDock { get; }

        bool InLid { get; }

        Windows.Devices.Enumeration.Panel Panel { get; }
    }
}

