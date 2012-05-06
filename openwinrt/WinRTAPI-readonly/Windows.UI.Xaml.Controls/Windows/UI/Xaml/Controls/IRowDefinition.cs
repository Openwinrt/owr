namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x4abae829, 0xd80c, 0x4a5e, 0xa4, 140, 0xf8, 0xb3, 0xd3, 0xb6, 0x53, 0x3d), WebHostHidden, ExclusiveTo(typeof(RowDefinition)), Version(0x6020000)]
    internal interface IRowDefinition
    {
        double ActualHeight { get; }

        GridLength Height { get; [param: In] set; }

        double MaxHeight { get; [param: In] set; }

        double MinHeight { get; [param: In] set; }
    }
}

