namespace Windows.UI.Xaml.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Flags]
    public enum ManipulationModes : uint
    {
        All = 0xffff,
        None = 0,
        Rotate = 0x10,
        RotateInertia = 0x80,
        Scale = 0x20,
        ScaleInertia = 0x100,
        System = 0x10000,
        TranslateInertia = 0x40,
        TranslateRailsX = 4,
        TranslateRailsY = 8,
        TranslateX = 1,
        TranslateY = 2
    }
}

