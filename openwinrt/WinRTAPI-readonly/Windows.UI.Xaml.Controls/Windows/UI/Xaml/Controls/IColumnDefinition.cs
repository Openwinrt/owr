namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ColumnDefinition)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf7f1b229, 0xf024, 0x467f, 0x97, 10, 0x7e, 0x70, 0x56, 0x15, 0xdb, 0x7b), Version(0x6020000)]
    internal interface IColumnDefinition
    {
        double ActualWidth { get; }

        double MaxWidth { get; [param: In] set; }

        double MinWidth { get; [param: In] set; }

        GridLength Width { get; [param: In] set; }
    }
}

