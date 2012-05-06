namespace Windows.UI.Core.AnimationMetrics
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x803aabe5, 0xee7e, 0x455f, 0x84, 0xe9, 0x25, 6, 0xaf, 0xb8, 210, 180), Version(0x6020000), ExclusiveTo(typeof(OpacityAnimation))]
    internal interface IOpacityAnimation : IPropertyAnimation
    {
        float FinalOpacity { get; }

        IReference<float> InitialOpacity { get; }
    }
}

