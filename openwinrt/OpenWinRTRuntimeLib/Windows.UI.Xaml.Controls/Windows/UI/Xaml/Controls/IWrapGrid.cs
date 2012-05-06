namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(WrapGrid)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x552178b, 0x7567, 0x47c2, 0xbd, 0x5c, 0xad, 0x83, 0x94, 200, 40, 0xba)]
    internal interface IWrapGrid
    {
        HorizontalAlignment HorizontalChildrenAlignment { get; [param: In] set; }

        double ItemHeight { get; [param: In] set; }

        double ItemWidth { get; [param: In] set; }

        int MaximumRowsOrColumns { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }

        VerticalAlignment VerticalChildrenAlignment { get; [param: In] set; }
    }
}

