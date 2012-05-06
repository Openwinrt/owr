namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(EasingPointKeyFrame)), Windows.Foundation.Metadata.Guid(0xb3c91380, 0x6868, 0x4225, 0xa7, 11, 0x39, 0x81, 0xcc, 11, 0x29, 0x47)]
    internal interface IEasingPointKeyFrame
    {
        EasingFunctionBase EasingFunction { get; [param: In] set; }
    }
}

