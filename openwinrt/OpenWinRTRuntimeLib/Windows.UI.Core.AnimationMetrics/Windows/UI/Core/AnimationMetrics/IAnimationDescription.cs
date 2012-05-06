namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x7d11a549, 0xbe3d, 0x41de, 0xb0, 0x81, 5, 0xc1, 0x49, 150, 0x2f, 0x9b), Version(0x6020000), ExclusiveTo(typeof(AnimationDescription))]
    internal interface IAnimationDescription
    {
        IVectorView<IPropertyAnimation> Animations { get; }

        Windows.Foundation.TimeSpan DelayLimit { get; }

        Windows.Foundation.TimeSpan StaggerDelay { get; }

        float StaggerDelayFactor { get; }

        int ZOrder { get; }
    }
}

