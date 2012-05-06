namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(VariableSizedWrapGrid)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9ca507c7, 0x23c9, 0x4f01, 0xb8, 15, 190, 0x5c, 0x21, 0xee, 0xf4, 0x74), WebHostHidden]
    internal interface IVariableSizedWrapGrid
    {
        HorizontalAlignment HorizontalChildrenAlignment { get; [param: In] set; }

        double ItemHeight { get; [param: In] set; }

        double ItemWidth { get; [param: In] set; }

        int MaximumRowsOrColumns { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }

        VerticalAlignment VerticalChildrenAlignment { get; [param: In] set; }
    }
}

