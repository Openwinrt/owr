namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xb8ae8a15, 0xf63, 0x4694, 0x94, 0x67, 0xbd, 0xaf, 0xac, 0x12, 0x53, 0xea), ExclusiveTo(typeof(ColorAnimation)), WebHostHidden]
    internal interface IColorAnimation
    {
        IReference<Color> By { get; [param: In] set; }

        EasingFunctionBase EasingFunction { get; [param: In] set; }

        bool EnableDependentAnimation { get; [param: In] set; }

        IReference<Color> From { get; [param: In] set; }

        IReference<Color> To { get; [param: In] set; }
    }
}

