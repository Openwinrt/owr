﻿namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [WebHostHidden, ContentProperty(Name="KeyFrames"), Static(typeof(IDoubleAnimationUsingKeyFramesStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DoubleAnimationUsingKeyFrames : Timeline, IDoubleAnimationUsingKeyFrames
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DoubleAnimationUsingKeyFrames();

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DoubleKeyFrameCollection KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Media.Animation.IDoubleAnimationUsingKeyFrames.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DoubleKeyFrameCollection Windows.UI.Xaml.Media.Animation.IDoubleAnimationUsingKeyFrames.KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

