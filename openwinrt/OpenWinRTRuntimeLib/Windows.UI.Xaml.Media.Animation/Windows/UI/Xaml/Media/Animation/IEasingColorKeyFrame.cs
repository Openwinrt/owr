namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc733d630, 0xf4b9, 0x4934, 0x9b, 0xdd, 0x27, 0xac, 0x5e, 0xd1, 0xcf, 0xd8), ExclusiveTo(typeof(EasingColorKeyFrame)), WebHostHidden, Version(0x6020000)]
    internal interface IEasingColorKeyFrame
    {
        EasingFunctionBase EasingFunction { get; [param: In] set; }
    }
}

