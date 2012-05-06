namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SplinePointKeyFrame)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf19f306, 0x7036, 0x494f, 0xbc, 60, 120, 13, 240, 0xcc, 0x52, 0x4a)]
    internal interface ISplinePointKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeySpline KeySpline { get; [param: In] set; }
    }
}

