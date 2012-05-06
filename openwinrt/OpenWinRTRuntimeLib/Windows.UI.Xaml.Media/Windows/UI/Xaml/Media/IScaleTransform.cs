namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ScaleTransform)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xed67f18d, 0x936e, 0x43ab, 0x92, 0x9a, 0xe9, 0xcd, 10, 0x51, 30, 0x52), WebHostHidden]
    internal interface IScaleTransform
    {
        double CenterX { get; [param: In] set; }

        double CenterY { get; [param: In] set; }

        double ScaleX { get; [param: In] set; }

        double ScaleY { get; [param: In] set; }
    }
}

