namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class ItemsPresenter : FrameworkElement, IItemsPresenter
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemsPresenter();
    }
}

