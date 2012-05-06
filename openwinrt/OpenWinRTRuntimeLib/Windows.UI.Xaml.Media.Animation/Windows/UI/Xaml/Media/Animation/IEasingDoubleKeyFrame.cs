namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(EasingDoubleKeyFrame)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x965adb8d, 0x9a54, 0x4108, 180, 0xff, 0xb5, 0xa5, 0x21, 0x2c, 0xb3, 0x38)]
    internal interface IEasingDoubleKeyFrame
    {
        EasingFunctionBase EasingFunction { get; [param: In] set; }
    }
}

