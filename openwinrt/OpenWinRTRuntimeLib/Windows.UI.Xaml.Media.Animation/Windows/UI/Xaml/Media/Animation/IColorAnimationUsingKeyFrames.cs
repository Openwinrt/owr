namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ColorAnimationUsingKeyFrames)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf5c82640, 0x13c3, 0x42aa, 0x9a, 0xe2, 0x7e, 0x6b, 0x51, 0xc9, 0x2f, 0x95)]
    internal interface IColorAnimationUsingKeyFrames
    {
        bool EnableDependentAnimation { get; [param: In] set; }

        ColorKeyFrameCollection KeyFrames { get; }
    }
}

