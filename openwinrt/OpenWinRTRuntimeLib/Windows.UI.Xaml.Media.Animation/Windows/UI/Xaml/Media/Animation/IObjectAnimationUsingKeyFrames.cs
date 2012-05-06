namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ObjectAnimationUsingKeyFrames)), Windows.Foundation.Metadata.Guid(0x334a2d92, 0xb74a, 0x4c64, 0xb9, 0xa6, 0x58, 0xbc, 250, 0x31, 0x4f, 0x22), WebHostHidden, Version(0x6020000)]
    internal interface IObjectAnimationUsingKeyFrames
    {
        bool EnableDependentAnimation { get; [param: In] set; }

        ObjectKeyFrameCollection KeyFrames { get; }
    }
}

