namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc201cf06, 0xcd84, 0x48a5, 150, 7, 0x66, 0x4d, 0x73, 0x61, 0xcd, 0x61), ExclusiveTo(typeof(TileBrush)), Version(0x6020000), WebHostHidden]
    internal interface ITileBrush
    {
        Windows.UI.Xaml.Media.AlignmentX AlignmentX { get; [param: In] set; }

        Windows.UI.Xaml.Media.AlignmentY AlignmentY { get; [param: In] set; }

        Windows.UI.Xaml.Media.Stretch Stretch { get; [param: In] set; }
    }
}

