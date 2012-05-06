namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media.Animation;

    [ContentProperty(Name="Items"), Version(0x6020000), Static(typeof(IItemsControlStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IItemsControlFactory), CompositionType.Public, 0x6020000), WebHostHidden]
    public class ItemsControl : Control, IItemsControl, IItemsControlOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemsControl();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void ClearContainerForItemOverride([In] DependencyObject element, [In] object item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual DependencyObject GetContainerForItemOverride();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ItemsControl GetItemsOwner([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsItemItsOwnContainerOverride([In] object item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ItemsControl ItemsControlFromItemContainer([In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnGroupStyleSelectorChanged([In] Windows.UI.Xaml.Controls.GroupStyleSelector oldGroupStyleSelector, [In] Windows.UI.Xaml.Controls.GroupStyleSelector newGroupStyleSelector);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemContainerStyleChanged([In] Style oldItemContainerStyle, [In] Style newItemContainerStyle);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemContainerStyleSelectorChanged([In] StyleSelector oldItemContainerStyleSelector, [In] StyleSelector newItemContainerStyleSelector);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemsChanged([In] object e);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemTemplateChanged([In] DataTemplate oldItemTemplate, [In] DataTemplate newItemTemplate);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemTemplateSelectorChanged([In] DataTemplateSelector oldItemTemplateSelector, [In] DataTemplateSelector newItemTemplateSelector);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void PrepareContainerForItemOverride([In] DependencyObject element, [In] object item);

        public string DisplayMemberPath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DisplayMemberPathProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IObservableVector<Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.GroupStyleSelector GroupStyleSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty GroupStyleSelectorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsGrouping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsGroupingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.ItemContainerGenerator ItemContainerGenerator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Style ItemContainerStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemContainerStyleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public StyleSelector ItemContainerStyleSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemContainerStyleSelectorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransitionCollection ItemContainerTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemContainerTransitionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ItemCollection Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ItemsPanelTemplate ItemsPanel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemsPanelProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object ItemsSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemsSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate ItemTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemTemplateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplateSelector ItemTemplateSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemTemplateSelectorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Controls.IItemsControl.DisplayMemberPath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IObservableVector<Windows.UI.Xaml.Controls.GroupStyle> Windows.UI.Xaml.Controls.IItemsControl.GroupStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.GroupStyleSelector Windows.UI.Xaml.Controls.IItemsControl.GroupStyleSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IItemsControl.IsGrouping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.ItemContainerGenerator Windows.UI.Xaml.Controls.IItemsControl.ItemContainerGenerator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Style Windows.UI.Xaml.Controls.IItemsControl.ItemContainerStyle { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public StyleSelector Windows.UI.Xaml.Controls.IItemsControl.ItemContainerStyleSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TransitionCollection Windows.UI.Xaml.Controls.IItemsControl.ItemContainerTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ItemCollection Windows.UI.Xaml.Controls.IItemsControl.Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ItemsPanelTemplate Windows.UI.Xaml.Controls.IItemsControl.ItemsPanel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.IItemsControl.ItemsSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplate Windows.UI.Xaml.Controls.IItemsControl.ItemTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplateSelector Windows.UI.Xaml.Controls.IItemsControl.ItemTemplateSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

