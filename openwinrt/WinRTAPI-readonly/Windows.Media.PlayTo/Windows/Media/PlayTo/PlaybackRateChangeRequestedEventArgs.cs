namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class PlaybackRateChangeRequestedEventArgs : IPlaybackRateChangeRequestedEventArgs
    {
        public double Rate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.PlayTo.IPlaybackRateChangeRequestedEventArgs.Rate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

