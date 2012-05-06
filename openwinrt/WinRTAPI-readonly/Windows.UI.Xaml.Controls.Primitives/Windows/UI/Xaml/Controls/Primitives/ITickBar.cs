namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, ExclusiveTo(typeof(TickBar)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x994683fa, 0xf1f6, 0x487d, 0xa5, 0xac, 0xc1, 0x59, 0x21, 0xbf, 0xa9, 0x95)]
    internal interface ITickBar
    {
        Brush Fill { get; [param: In] set; }
    }
}

