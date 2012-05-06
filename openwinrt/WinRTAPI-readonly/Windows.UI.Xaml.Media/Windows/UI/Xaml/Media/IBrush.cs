namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(Brush)), Windows.Foundation.Metadata.Guid(0x8806a321, 0x1e06, 0x422c, 0xa1, 0xcc, 1, 0x69, 0x65, 0x59, 0xe0, 0x21), WebHostHidden]
    internal interface IBrush
    {
        double Opacity { get; [param: In] set; }

        Windows.UI.Xaml.Media.Transform RelativeTransform { get; [param: In] set; }

        Windows.UI.Xaml.Media.Transform Transform { get; [param: In] set; }
    }
}

