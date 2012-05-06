namespace Windows.UI.Xaml
{
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class SizeChangedEventArgs : RoutedEventArgs, ISizeChangedEventArgs
    {
        public Size NewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size PreviousSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.Xaml.ISizeChangedEventArgs.NewSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.Xaml.ISizeChangedEventArgs.PreviousSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

