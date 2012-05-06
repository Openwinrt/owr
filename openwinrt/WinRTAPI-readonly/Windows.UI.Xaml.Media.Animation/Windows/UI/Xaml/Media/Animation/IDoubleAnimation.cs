namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(DoubleAnimation)), Windows.Foundation.Metadata.Guid(0x7e9f3d59, 0xf07, 0x4bc9, 0x97, 0x7d, 3, 0x76, 0x3f, 0xf8, 0x15, 0x4f), WebHostHidden]
    internal interface IDoubleAnimation
    {
        IReference<double> By { get; [param: In] set; }

        EasingFunctionBase EasingFunction { get; [param: In] set; }

        bool EnableDependentAnimation { get; [param: In] set; }

        IReference<double> From { get; [param: In] set; }

        IReference<double> To { get; [param: In] set; }
    }
}

