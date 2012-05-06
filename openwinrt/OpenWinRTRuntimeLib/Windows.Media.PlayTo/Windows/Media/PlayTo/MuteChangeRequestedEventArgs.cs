namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class MuteChangeRequestedEventArgs : IMuteChangeRequestedEventArgs
    {
        public bool Mute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.PlayTo.IMuteChangeRequestedEventArgs.Mute { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

