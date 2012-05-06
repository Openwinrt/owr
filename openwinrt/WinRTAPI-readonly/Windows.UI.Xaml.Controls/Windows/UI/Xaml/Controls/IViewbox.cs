namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x5252c58, 0xba9d, 0x4809, 0x9e, 0xc3, 250, 13, 0x16, 0x71, 11, 0xa1), ExclusiveTo(typeof(Viewbox)), Version(0x6020000)]
    internal interface IViewbox
    {
        UIElement Child { get; [param: In] set; }

        Windows.UI.Xaml.Media.Stretch Stretch { get; [param: In] set; }

        Windows.UI.Xaml.Controls.StretchDirection StretchDirection { get; [param: In] set; }
    }
}

