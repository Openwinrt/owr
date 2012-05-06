namespace Windows.Devices.Printers.Extensions
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintTaskConfigurationSaveRequestedEventArgs)), Version(0x6020000), Guid(0xe06c2879, 0xd61, 0x4938, 0x91, 0xd0, 150, 0xa4, 0x5b, 0xee, 0x84, 0x79)]
    internal interface IPrintTaskConfigurationSaveRequestedEventArgs
    {
        PrintTaskConfigurationSaveRequest Request { get; }
    }
}

