namespace Windows.Graphics.Display
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6937ed8d, 0x30ea, 0x4ded, 130, 0x71, 0x45, 0x53, 0xff, 2, 0xf6, 0x8a), ExclusiveTo(typeof(DisplayProperties))]
    internal interface IDisplayPropertiesStatics
    {
        event DisplayPropertiesEventHandler ColorProfileChanged;

        event DisplayPropertiesEventHandler LogicalDpiChanged;

        event DisplayPropertiesEventHandler OrientationChanged;

        event DisplayPropertiesEventHandler StereoEnabledChanged;

        IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

        DisplayOrientations AutoRotationPreferences { get; [param: In] set; }

        DisplayOrientations CurrentOrientation { get; }

        float LogicalDpi { get; }

        DisplayOrientations NativeOrientation { get; }

        Windows.Graphics.Display.ResolutionScale ResolutionScale { get; }

        bool StereoEnabled { get; }
    }
}

