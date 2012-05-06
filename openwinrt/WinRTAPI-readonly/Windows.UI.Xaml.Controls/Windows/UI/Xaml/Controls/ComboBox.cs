namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IComboBoxStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Composable(typeof(IComboBoxFactory), CompositionType.Public, 0x6020000)]
    public class ComboBox : Selector, IComboBox, IComboBoxOverrides
    {
        public event Windows.Foundation.EventHandler<object> DropDownClosed;

        public event Windows.Foundation.EventHandler<object> DropDownOpened;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.IComboBox.DropDownClosed;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.Controls.IComboBox.DropDownOpened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ComboBox();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnDropDownClosed([In] object e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnDropDownOpened([In] object e);

        public bool IsDropDownOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsDropDownOpenProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsEditable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsSelectionBoxHighlighted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxDropDownHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxDropDownHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object SelectionBoxItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate SelectionBoxItemTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ComboBoxTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IComboBox.IsDropDownOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IComboBox.IsEditable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IComboBox.IsSelectionBoxHighlighted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IComboBox.MaxDropDownHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.IComboBox.SelectionBoxItem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate Windows.UI.Xaml.Controls.IComboBox.SelectionBoxItemTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ComboBoxTemplateSettings Windows.UI.Xaml.Controls.IComboBox.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

