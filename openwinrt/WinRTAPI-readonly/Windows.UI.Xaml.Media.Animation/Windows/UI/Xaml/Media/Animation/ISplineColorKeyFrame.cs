namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1a4a5941, 0x1fe0, 0x473a, 0x8e, 0xfe, 0x43, 0x16, 0xd8, 200, 0x62, 0x29), ExclusiveTo(typeof(SplineColorKeyFrame)), WebHostHidden]
    internal interface ISplineColorKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeySpline KeySpline { get; [param: In] set; }
    }
}

