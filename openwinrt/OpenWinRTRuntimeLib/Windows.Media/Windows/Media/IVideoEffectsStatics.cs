namespace Windows.Media
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x1fcda5e8, 0xbaf1, 0x4521, 0x98, 12, 0x3b, 0xce, 0xbb, 0x44, 0xcf, 0x38), Version(0x6020000), ExclusiveTo(typeof(VideoEffects))]
    internal interface IVideoEffectsStatics
    {
        string VideoStabilization { get; }
    }
}

