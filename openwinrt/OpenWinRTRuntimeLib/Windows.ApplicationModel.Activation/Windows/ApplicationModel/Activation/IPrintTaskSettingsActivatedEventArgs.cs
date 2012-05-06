namespace Windows.ApplicationModel.Activation
{
    using Windows.Devices.Printers.Extensions;
    using Windows.Foundation.Metadata;

    [Guid(0xee30a0c9, 0xce56, 0x4865, 0xba, 0x8e, 0x89, 0x54, 0xac, 0x27, 0x11, 7), Version(0x6020000)]
    public interface IPrintTaskSettingsActivatedEventArgs : IActivatedEventArgs
    {
        PrintTaskConfiguration Configuration { get; }
    }
}

