namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(PointAnimationUsingKeyFrames)), Windows.Foundation.Metadata.Guid(0x9b944f72, 0x446a, 0x41d0, 0xa1, 0x29, 0x41, 0xa6, 0x20, 0xf4, 0x59, 0x5d)]
    internal interface IPointAnimationUsingKeyFrames
    {
        bool EnableDependentAnimation { get; [param: In] set; }

        PointKeyFrameCollection KeyFrames { get; }
    }
}

