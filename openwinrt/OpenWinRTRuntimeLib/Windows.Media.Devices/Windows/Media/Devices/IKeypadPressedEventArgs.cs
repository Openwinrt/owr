namespace Windows.Media.Devices
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(KeypadPressedEventArgs)), Guid(0xd3a43900, 0xb4fa, 0x49cd, 0x94, 0x42, 0x89, 0xaf, 0x65, 0x68, 0xf6, 1)]
    internal interface IKeypadPressedEventArgs
    {
        Windows.Media.Devices.TelephonyKey TelephonyKey { get; }
    }
}

