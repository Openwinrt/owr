namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Composable(typeof(IExceptionRoutedEventArgsFactory), CompositionType.Public, 0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class ExceptionRoutedEventArgs : RoutedEventArgs, IExceptionRoutedEventArgs
    {
        public string ErrorMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.IExceptionRoutedEventArgs.ErrorMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

