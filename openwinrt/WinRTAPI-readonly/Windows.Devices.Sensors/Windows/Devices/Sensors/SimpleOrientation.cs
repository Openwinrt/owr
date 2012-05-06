namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SimpleOrientation
    {
        NotRotated,
        Rotated90DegreesCounterclockwise,
        Rotated180DegreesCounterclockwise,
        Rotated270DegreesCounterclockwise,
        Faceup,
        Facedown
    }
}

