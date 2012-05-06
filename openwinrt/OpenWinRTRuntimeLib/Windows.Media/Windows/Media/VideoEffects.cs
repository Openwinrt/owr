namespace Windows.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Static(typeof(IVideoEffectsStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public static class VideoEffects
    {
        public static string VideoStabilization { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

