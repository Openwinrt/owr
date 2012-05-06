namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DragDeltaEventArgs)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x46e7a1ef, 0xae15, 0x44a6, 0x8a, 4, 0x95, 0xb0, 0xbf, 0x9a, 0xb8, 0x76)]
    internal interface IDragDeltaEventArgsFactory
    {
        DragDeltaEventArgs CreateInstanceWithHorizontalChangeAndVerticalChange([In] double horizontalChange, [In] double verticalChange, [In] object outer, out object inner);
    }
}

