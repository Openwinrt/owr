namespace Windows.Devices.Printers.Extensions
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xe959d568, 0xf729, 0x44a4, 0x87, 0x1d, 0xbd, 6, 40, 0x69, 0x6a, 0x33), ExclusiveTo(typeof(PrintTaskConfigurationSaveRequestedDeferral))]
    internal interface IPrintTaskConfigurationSaveRequestedDeferral
    {
        void Complete();
    }
}

