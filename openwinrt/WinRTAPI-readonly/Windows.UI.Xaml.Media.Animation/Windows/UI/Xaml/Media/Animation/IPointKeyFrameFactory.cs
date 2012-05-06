namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PointKeyFrame)), Windows.Foundation.Metadata.Guid(0xcb214bdf, 0x426a, 0x4392, 0x83, 0x55, 0xc2, 0xae, 0x52, 0x85, 0x26, 0x23), WebHostHidden]
    internal interface IPointKeyFrameFactory
    {
        PointKeyFrame CreateInstance([In] object outer, out object inner);
    }
}

