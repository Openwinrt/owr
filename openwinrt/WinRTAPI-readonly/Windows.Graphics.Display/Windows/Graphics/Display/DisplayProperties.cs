namespace Windows.Graphics.Display
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IDisplayPropertiesStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public static class DisplayProperties
    {
        public static  event DisplayPropertiesEventHandler ColorProfileChanged;

        public static  event DisplayPropertiesEventHandler LogicalDpiChanged;

        public static  event DisplayPropertiesEventHandler OrientationChanged;

        public static  event DisplayPropertiesEventHandler StereoEnabledChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

        public static DisplayOrientations AutoRotationPreferences { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DisplayOrientations CurrentOrientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static float LogicalDpi { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DisplayOrientations NativeOrientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Windows.Graphics.Display.ResolutionScale ResolutionScale { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static bool StereoEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

