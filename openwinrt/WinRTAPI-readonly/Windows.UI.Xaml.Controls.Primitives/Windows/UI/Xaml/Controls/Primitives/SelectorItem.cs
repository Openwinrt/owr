namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(ISelectorItemStatics), 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(ISelectorItemFactory), CompositionType.Protected, 0x6020000)]
    public class SelectorItem : ContentControl, ISelectorItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected SelectorItem();

        public bool IsSelected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsSelectedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.ISelectorItem.IsSelected { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

