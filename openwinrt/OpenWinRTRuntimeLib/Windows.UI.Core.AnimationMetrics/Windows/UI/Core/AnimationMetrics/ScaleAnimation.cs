namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ScaleAnimation : IScaleAnimation, IPropertyAnimation
    {
        public Point Control1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Control2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float FinalScaleX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float FinalScaleY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> InitialScaleX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> InitialScaleY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point NormalizedOrigin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyAnimationType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Control1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Control2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyAnimationType Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Core.AnimationMetrics.IScaleAnimation.FinalScaleX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Core.AnimationMetrics.IScaleAnimation.FinalScaleY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> Windows.UI.Core.AnimationMetrics.IScaleAnimation.InitialScaleX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> Windows.UI.Core.AnimationMetrics.IScaleAnimation.InitialScaleY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Core.AnimationMetrics.IScaleAnimation.NormalizedOrigin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

