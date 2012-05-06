namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden]
    public sealed class TextChangedEventArgs : RoutedEventArgs, ITextChangedEventArgs
    {
    }
}

