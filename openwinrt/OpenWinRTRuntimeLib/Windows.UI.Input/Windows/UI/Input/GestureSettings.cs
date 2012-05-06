namespace Windows.UI.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum GestureSettings : uint
    {
        CrossSlide = 0x8000,
        DoubleTap = 2,
        Drag = 0x20,
        Hold = 4,
        HoldWithMouse = 8,
        ManipulationRotate = 0x400,
        ManipulationRotateInertia = 0x2000,
        ManipulationScale = 0x800,
        ManipulationScaleInertia = 0x4000,
        ManipulationTranslateInertia = 0x1000,
        ManipulationTranslateRailsX = 0x100,
        ManipulationTranslateRailsY = 0x200,
        ManipulationTranslateX = 0x40,
        ManipulationTranslateY = 0x80,
        None = 0,
        RightTap = 0x10,
        Tap = 1
    }
}

