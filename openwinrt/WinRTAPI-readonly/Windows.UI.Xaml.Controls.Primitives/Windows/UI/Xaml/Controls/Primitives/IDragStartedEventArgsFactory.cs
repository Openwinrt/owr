namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5eefe579, 0xc706, 0x4781, 0xa3, 8, 0xc9, 0xe7, 0xf4, 0xc6, 0xa1, 0xd7), WebHostHidden, ExclusiveTo(typeof(DragStartedEventArgs))]
    internal interface IDragStartedEventArgsFactory
    {
        DragStartedEventArgs CreateInstanceWithHorizontalOffsetAndVerticalOffset([In] double horizontalOffset, [In] double verticalOffset, [In] object outer, out object inner);
    }
}

