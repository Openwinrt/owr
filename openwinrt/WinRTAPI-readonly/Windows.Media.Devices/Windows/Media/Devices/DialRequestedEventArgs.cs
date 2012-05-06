namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DialRequestedEventArgs : IDialRequestedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Handled();

        public object Contact { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Media.Devices.IDialRequestedEventArgs.Contact { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

