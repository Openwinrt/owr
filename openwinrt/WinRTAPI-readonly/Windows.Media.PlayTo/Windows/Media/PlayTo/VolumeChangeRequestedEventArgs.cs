namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class VolumeChangeRequestedEventArgs : IVolumeChangeRequestedEventArgs
    {
        public double Volume { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Media.PlayTo.IVolumeChangeRequestedEventArgs.Volume { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

