namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum PointOptions : uint
    {
        AllowOffClient = 0x200,
        ClientCoordinates = 0x100,
        IncludeInset = 1,
        NoHorizontalScroll = 0x10000,
        None = 0,
        NoVerticalScroll = 0x40000,
        Start = 0x20,
        Transform = 0x400
    }
}

