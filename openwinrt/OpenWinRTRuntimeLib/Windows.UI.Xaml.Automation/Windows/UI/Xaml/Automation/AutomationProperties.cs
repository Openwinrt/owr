namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Static(typeof(IAutomationPropertiesStatics), 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class AutomationProperties : IAutomationProperties
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetAcceleratorKey([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetAccessKey([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetAutomationId([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetHelpText([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetIsRequiredForForm([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetItemStatus([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetItemType([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static UIElement GetLabeledBy([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetName([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetAcceleratorKey([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetAccessKey([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetAutomationId([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHelpText([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetIsRequiredForForm([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetItemStatus([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetItemType([In] DependencyObject element, [In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetLabeledBy([In] DependencyObject element, [In] UIElement value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetName([In] DependencyObject element, [In] string value);

        public static DependencyProperty AcceleratorKeyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty AccessKeyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty AutomationIdProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty HelpTextProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsRequiredForFormProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ItemStatusProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ItemTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty LabeledByProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

