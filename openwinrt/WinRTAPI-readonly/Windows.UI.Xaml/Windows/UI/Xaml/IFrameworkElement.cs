namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Data;

    [ExclusiveTo(typeof(FrameworkElement)), Windows.Foundation.Metadata.Guid(0xa391d09b, 0x4a99, 0x4b7c, 0x9d, 0x8d, 0x6f, 0xa5, 0xd0, 0x1f, 0x6f, 0xbf), WebHostHidden, Version(0x6020000)]
    internal interface IFrameworkElement
    {
        event Windows.Foundation.EventHandler<object> LayoutUpdated;

        event RoutedEventHandler Loaded;

        event SizeChangedEventHandler SizeChanged;

        event RoutedEventHandler Unloaded;

        object FindName([In] string name);
        void SetBinding([In] DependencyProperty dp, [In] BindingBase binding);

        double ActualHeight { get; }

        double ActualWidth { get; }

        Uri BaseUri { get; }

        object DataContext { get; [param: In] set; }

        Windows.UI.Xaml.FlowDirection FlowDirection { get; [param: In] set; }

        double Height { get; [param: In] set; }

        Windows.UI.Xaml.HorizontalAlignment HorizontalAlignment { get; [param: In] set; }

        string Language { get; [param: In] set; }

        Thickness Margin { get; [param: In] set; }

        double MaxHeight { get; [param: In] set; }

        double MaxWidth { get; [param: In] set; }

        double MinHeight { get; [param: In] set; }

        double MinWidth { get; [param: In] set; }

        string Name { get; [param: In] set; }

        DependencyObject Parent { get; }

        ResourceDictionary Resources { get; [param: In] set; }

        Windows.UI.Xaml.Style Style { get; [param: In] set; }

        object Tag { get; [param: In] set; }

        TriggerCollection Triggers { get; }

        Windows.UI.Xaml.VerticalAlignment VerticalAlignment { get; [param: In] set; }

        double Width { get; [param: In] set; }
    }
}

