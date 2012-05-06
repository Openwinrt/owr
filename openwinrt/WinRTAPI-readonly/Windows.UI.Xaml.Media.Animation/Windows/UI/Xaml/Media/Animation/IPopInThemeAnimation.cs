namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PopInThemeAnimation)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x196938c1, 0x1c07, 0x4c28, 0x88, 0x47, 0xf9, 240, 0x55, 0xb3, 40, 0x55), WebHostHidden]
    internal interface IPopInThemeAnimation
    {
        double FromHorizontalOffset { get; [param: In] set; }

        double FromVerticalOffset { get; [param: In] set; }

        string TargetName { get; [param: In] set; }
    }
}

