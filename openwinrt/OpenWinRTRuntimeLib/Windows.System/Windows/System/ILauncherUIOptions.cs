namespace Windows.System
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Version(0x6020000), ExclusiveTo(typeof(LauncherUIOptions)), Windows.Foundation.Metadata.Guid(0x1b25da6e, 0x8aa6, 0x41e9, 130, 0x51, 0x41, 0x65, 0xf5, 0x98, 0x5f, 0x49)]
    internal interface ILauncherUIOptions
    {
        IReference<Point> InvocationPoint { get; [param: In] set; }

        Placement PreferredPlacement { get; [param: In] set; }

        IReference<Rect> SelectionRect { get; [param: In] set; }
    }
}

