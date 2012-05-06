namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class CurrentTimeChangeRequestedEventArgs : ICurrentTimeChangeRequestedEventArgs
    {
        public Windows.Foundation.TimeSpan Time { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.Media.PlayTo.ICurrentTimeChangeRequestedEventArgs.Time { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

