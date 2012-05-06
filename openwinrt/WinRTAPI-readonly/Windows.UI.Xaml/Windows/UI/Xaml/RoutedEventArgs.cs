namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Composable(typeof(IRoutedEventArgsFactory), CompositionType.Public, 0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class RoutedEventArgs : IRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RoutedEventArgs();

        public object OriginalSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.IRoutedEventArgs.OriginalSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

