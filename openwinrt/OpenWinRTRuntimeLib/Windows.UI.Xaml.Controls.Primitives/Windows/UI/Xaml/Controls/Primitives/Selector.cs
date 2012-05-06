namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), Composable(typeof(ISelectorFactory), CompositionType.Protected, 0x6020000), Static(typeof(ISelectorStatics), 0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class Selector : ItemsControl, ISelector
    {
        public event SelectionChangedEventHandler SelectionChanged;

        public event SelectionChangedEventHandler Windows.UI.Xaml.Controls.Primitives.ISelector.SelectionChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsSelectionActive([In] DependencyObject element);

        public IReference<bool> IsSynchronizedWithCurrentItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsSynchronizedWithCurrentItemProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int SelectedIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SelectedIndexProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object SelectedItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SelectedItemProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object SelectedValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string SelectedValuePath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SelectedValuePathProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty SelectedValueProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<bool> Windows.UI.Xaml.Controls.Primitives.ISelector.IsSynchronizedWithCurrentItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Controls.Primitives.ISelector.SelectedIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.Primitives.ISelector.SelectedItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.Primitives.ISelector.SelectedValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Controls.Primitives.ISelector.SelectedValuePath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

