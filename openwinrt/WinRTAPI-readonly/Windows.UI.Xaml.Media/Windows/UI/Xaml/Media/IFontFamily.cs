namespace Windows.UI.Xaml.Media
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(FontFamily)), Guid(0x92467e64, 0xd66a, 0x4cf4, 0x93, 0x22, 0x3d, 0x23, 0xb3, 0xc0, 0xc3, 0x61), Version(0x6020000), WebHostHidden]
    internal interface IFontFamily
    {
        string Source { get; }
    }
}

