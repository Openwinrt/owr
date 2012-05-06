namespace Windows.Graphics.Display
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum DisplayOrientations : uint
    {
        Landscape = 1,
        LandscapeFlipped = 4,
        None = 0,
        Portrait = 2,
        PortraitFlipped = 8
    }
}

