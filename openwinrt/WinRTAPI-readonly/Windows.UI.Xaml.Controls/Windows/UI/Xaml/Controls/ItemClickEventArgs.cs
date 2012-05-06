namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000)]
    public sealed class ItemClickEventArgs : RoutedEventArgs, IItemClickEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemClickEventArgs();

        public object ClickedItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.Controls.IItemClickEventArgs.ClickedItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

