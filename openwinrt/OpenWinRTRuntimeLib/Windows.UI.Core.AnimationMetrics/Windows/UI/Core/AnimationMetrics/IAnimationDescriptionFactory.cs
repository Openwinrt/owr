namespace Windows.UI.Core.AnimationMetrics
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc6e27abe, 0xc1fb, 0x48b5, 0x92, 0x71, 0xec, 0xc7, 10, 200, 110, 240), Version(0x6020000), ExclusiveTo(typeof(AnimationDescription))]
    internal interface IAnimationDescriptionFactory
    {
        AnimationDescription CreateInstance([In] AnimationEffect effect, [In] AnimationEffectTarget target);
    }
}

