namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IListBoxFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IListBoxStatics), 0x6020000)]
    public class ListBox : Selector, IListBox
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListBox();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView([In] object item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SelectAll();

        public IVector<object> SelectedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.SelectionMode SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SelectionModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> Windows.UI.Xaml.Controls.IListBox.SelectedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.SelectionMode Windows.UI.Xaml.Controls.IListBox.SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

