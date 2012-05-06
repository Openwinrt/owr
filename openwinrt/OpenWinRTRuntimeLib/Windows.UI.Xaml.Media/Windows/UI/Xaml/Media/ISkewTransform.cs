namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4e8a3b15, 0x7a0f, 0x4617, 0x9e, 0x98, 30, 0x65, 0xbd, 0xc9, 0x21, 0x15), ExclusiveTo(typeof(SkewTransform)), Version(0x6020000), WebHostHidden]
    internal interface ISkewTransform
    {
        double AngleX { get; [param: In] set; }

        double AngleY { get; [param: In] set; }

        double CenterX { get; [param: In] set; }

        double CenterY { get; [param: In] set; }
    }
}

