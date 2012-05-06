namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x36a7d99d, 0x148c, 0x495f, 160, 0xfc, 0xaf, 200, 0x71, 0xd6, 0x2f, 0x33), ExclusiveTo(typeof(DragCompletedEventArgs)), WebHostHidden, Version(0x6020000)]
    internal interface IDragCompletedEventArgsFactory
    {
        DragCompletedEventArgs CreateInstanceWithHorizontalChangeVerticalChangeAndCanceled([In] double horizontalChange, [In] double verticalChange, [In] bool canceled, [In] object outer, out object inner);
    }
}

