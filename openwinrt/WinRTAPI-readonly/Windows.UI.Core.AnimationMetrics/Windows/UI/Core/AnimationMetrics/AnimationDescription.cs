namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Activatable(typeof(IAnimationDescriptionFactory), 0x6020000), Version(0x6020000)]
    public sealed class AnimationDescription : IAnimationDescription
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AnimationDescription([In] AnimationEffect effect, [In] AnimationEffectTarget target);

        public IVectorView<IPropertyAnimation> Animations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan DelayLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan StaggerDelay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float StaggerDelayFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<IPropertyAnimation> Windows.UI.Core.AnimationMetrics.IAnimationDescription.Animations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IAnimationDescription.DelayLimit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IAnimationDescription.StaggerDelay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Core.AnimationMetrics.IAnimationDescription.StaggerDelayFactor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Core.AnimationMetrics.IAnimationDescription.ZOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int ZOrder { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

