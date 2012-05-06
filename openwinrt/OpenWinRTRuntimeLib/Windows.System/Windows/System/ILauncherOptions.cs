namespace Windows.System
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(LauncherOptions)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbafa21d8, 0xb071, 0x4cd8, 0x85, 0x3e, 0x34, 0x12, 3, 0xe5, 0x57, 0xd3)]
    internal interface ILauncherOptions
    {
        bool DisplayApplicationPicker { get; [param: In] set; }

        bool TreatAsUntrusted { get; [param: In] set; }

        LauncherUIOptions UI { get; }
    }
}

