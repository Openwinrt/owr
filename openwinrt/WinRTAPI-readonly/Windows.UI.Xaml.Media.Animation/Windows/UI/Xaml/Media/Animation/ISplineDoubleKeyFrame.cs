namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SplineDoubleKeyFrame)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd72d38, 0x6b2b, 0x4843, 0x83, 0x8e, 200, 0xb1, 0x15, 0xee, 200, 1)]
    internal interface ISplineDoubleKeyFrame
    {
        Windows.UI.Xaml.Media.Animation.KeySpline KeySpline { get; [param: In] set; }
    }
}

