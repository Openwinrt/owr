namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(CleanUpVirtualizedItemEventArgs)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xea05cce9, 0x937c, 0x4120, 0x84, 6, 0x79, 0x21, 0x85, 120, 0x43, 0x38), Version(0x6020000)]
    internal interface ICleanUpVirtualizedItemEventArgs
    {
        bool Cancel { get; [param: In] set; }

        Windows.UI.Xaml.UIElement UIElement { get; }

        object Value { get; }
    }
}

