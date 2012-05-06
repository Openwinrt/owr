namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc108383f, 0x2c02, 0x4151, 0x8e, 0xcd, 0x68, 0xdd, 170, 0x3f, 13, 0x9b), WebHostHidden, ExclusiveTo(typeof(EasingFunctionBase))]
    internal interface IEasingFunctionBase
    {
        double Ease([In] double normalizedTime);

        Windows.UI.Xaml.Media.Animation.EasingMode EasingMode { get; [param: In] set; }
    }
}

