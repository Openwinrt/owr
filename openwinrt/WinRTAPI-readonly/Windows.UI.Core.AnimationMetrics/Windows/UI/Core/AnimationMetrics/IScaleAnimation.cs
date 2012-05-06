namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ScaleAnimation)), Version(0x6020000), Guid(0x23552c7, 0x71ab, 0x428c, 0x9c, 0x9f, 0xd3, 0x17, 0x80, 150, 0x49, 0x95)]
    internal interface IScaleAnimation : IPropertyAnimation
    {
        float FinalScaleX { get; }

        float FinalScaleY { get; }

        IReference<float> InitialScaleX { get; }

        IReference<float> InitialScaleY { get; }

        Point NormalizedOrigin { get; }
    }
}

