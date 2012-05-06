namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class RateChangedRoutedEventArgs : RoutedEventArgs, IRateChangedRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RateChangedRoutedEventArgs();
    }
}

