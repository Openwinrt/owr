namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4fee628f, 0xbfee, 0x4f75, 0x83, 0xc2, 0xa9, 0x3b, 0x39, 0x48, 0x84, 0x73), ExclusiveTo(typeof(DoubleAnimationUsingKeyFrames)), WebHostHidden, Version(0x6020000)]
    internal interface IDoubleAnimationUsingKeyFrames
    {
        bool EnableDependentAnimation { get; [param: In] set; }

        DoubleKeyFrameCollection KeyFrames { get; }
    }
}

