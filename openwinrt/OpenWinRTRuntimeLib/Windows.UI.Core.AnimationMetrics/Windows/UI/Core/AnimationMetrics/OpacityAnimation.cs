namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class OpacityAnimation : IOpacityAnimation, IPropertyAnimation
    {
        public Point Control1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Control2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float FinalOpacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> InitialOpacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyAnimationType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public float Windows.UI.Core.AnimationMetrics.IOpacityAnimation.FinalOpacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<float> Windows.UI.Core.AnimationMetrics.IOpacityAnimation.InitialOpacity { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Control1 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Control2 { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Delay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Duration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyAnimationType Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

