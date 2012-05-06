namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xead0ca44, 0x9ded, 0x4037, 0x81, 0x49, 0x5e, 0x4c, 0xc2, 0x56, 0x44, 0x68), ExclusiveTo(typeof(MouseWheelParameters))]
    internal interface IMouseWheelParameters
    {
        Point CharTranslation { get; [param: In] set; }

        float DeltaRotationAngle { get; [param: In] set; }

        float DeltaScale { get; [param: In] set; }

        Point PageTranslation { get; [param: In] set; }
    }
}

