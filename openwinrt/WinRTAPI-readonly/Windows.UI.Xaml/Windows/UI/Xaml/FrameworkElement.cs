namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Data;

    [Static(typeof(IFrameworkElementStatics), 0x6020000), Composable(typeof(IFrameworkElementFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class FrameworkElement : UIElement, IFrameworkElement, IFrameworkElementOverrides
    {
        public event Windows.Foundation.EventHandler<object> LayoutUpdated;

        public event RoutedEventHandler Loaded;

        public event SizeChangedEventHandler SizeChanged;

        public event RoutedEventHandler Unloaded;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.IFrameworkElement.LayoutUpdated;

        public event RoutedEventHandler Windows.UI.Xaml.IFrameworkElement.Loaded;

        public event SizeChangedEventHandler Windows.UI.Xaml.IFrameworkElement.SizeChanged;

        public event RoutedEventHandler Windows.UI.Xaml.IFrameworkElement.Unloaded;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected FrameworkElement();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Size ArrangeOverride([In] Size finalSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object FindName([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Size MeasureOverride([In] Size availableSize);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnApplyTemplate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetBinding([In] DependencyProperty dp, [In] BindingBase binding);

        public double ActualHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ActualHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ActualWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ActualWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object DataContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DataContextProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.FlowDirection FlowDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FlowDirectionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.HorizontalAlignment HorizontalAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LanguageProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Margin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MarginProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MinHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MinWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty NameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DependencyObject Parent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceDictionary Resources { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Style Style { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StyleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TagProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TriggerCollection Triggers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.VerticalAlignment VerticalAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty WidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.IFrameworkElement.ActualHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.IFrameworkElement.ActualWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.UI.Xaml.IFrameworkElement.BaseUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.IFrameworkElement.DataContext { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.FlowDirection Windows.UI.Xaml.IFrameworkElement.FlowDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.HorizontalAlignment Windows.UI.Xaml.IFrameworkElement.HorizontalAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.IFrameworkElement.Language { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Thickness Windows.UI.Xaml.IFrameworkElement.Margin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.MaxHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.MaxWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.MinHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.MinWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.IFrameworkElement.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DependencyObject Windows.UI.Xaml.IFrameworkElement.Parent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ResourceDictionary Windows.UI.Xaml.IFrameworkElement.Resources { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Style Windows.UI.Xaml.IFrameworkElement.Style { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.IFrameworkElement.Tag { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TriggerCollection Windows.UI.Xaml.IFrameworkElement.Triggers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.VerticalAlignment Windows.UI.Xaml.IFrameworkElement.VerticalAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.IFrameworkElement.Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

