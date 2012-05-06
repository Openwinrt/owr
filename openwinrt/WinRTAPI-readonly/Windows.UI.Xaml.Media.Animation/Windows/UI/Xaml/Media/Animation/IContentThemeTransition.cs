namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ContentThemeTransition)), Windows.Foundation.Metadata.Guid(0xf66fc5c3, 0x5915, 0x437d, 0x8e, 0x3b, 0xad, 0xf8, 0xe7, 240, 0xab, 0x57), Version(0x6020000), WebHostHidden]
    internal interface IContentThemeTransition
    {
        double HorizontalOffset { get; [param: In] set; }

        double VerticalOffset { get; [param: In] set; }
    }
}

