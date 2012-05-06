namespace Windows.System
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000)]
    public sealed class LauncherOptions : ILauncherOptions
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LauncherOptions();

        public bool DisplayApplicationPicker { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool TreatAsUntrusted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public LauncherUIOptions UI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.System.ILauncherOptions.DisplayApplicationPicker { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.System.ILauncherOptions.TreatAsUntrusted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public LauncherUIOptions Windows.System.ILauncherOptions.UI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

