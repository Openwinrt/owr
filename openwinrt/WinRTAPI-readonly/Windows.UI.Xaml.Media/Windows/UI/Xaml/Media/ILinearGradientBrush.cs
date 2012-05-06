namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8e96d16b, 0xbb84, 0x4c6f, 0x9d, 0xbf, 0x9d, 0x6c, 0x5c, 0x6d, 0x9c, 0x39), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(LinearGradientBrush))]
    internal interface ILinearGradientBrush
    {
        Point EndPoint { get; [param: In] set; }

        Point StartPoint { get; [param: In] set; }
    }
}

