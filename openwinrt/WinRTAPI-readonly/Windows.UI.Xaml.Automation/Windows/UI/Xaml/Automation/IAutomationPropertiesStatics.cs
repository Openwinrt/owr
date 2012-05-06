namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xb618fd7b, 0x32d0, 0x4970, 0x9c, 0x42, 0x7c, 3, 0x9a, 0xc7, 190, 120), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(AutomationProperties))]
    internal interface IAutomationPropertiesStatics
    {
        string GetAcceleratorKey([In] DependencyObject element);
        string GetAccessKey([In] DependencyObject element);
        string GetAutomationId([In] DependencyObject element);
        string GetHelpText([In] DependencyObject element);
        bool GetIsRequiredForForm([In] DependencyObject element);
        string GetItemStatus([In] DependencyObject element);
        string GetItemType([In] DependencyObject element);
        UIElement GetLabeledBy([In] DependencyObject element);
        string GetName([In] DependencyObject element);
        void SetAcceleratorKey([In] DependencyObject element, [In] string value);
        void SetAccessKey([In] DependencyObject element, [In] string value);
        void SetAutomationId([In] DependencyObject element, [In] string value);
        void SetHelpText([In] DependencyObject element, [In] string value);
        void SetIsRequiredForForm([In] DependencyObject element, [In] bool value);
        void SetItemStatus([In] DependencyObject element, [In] string value);
        void SetItemType([In] DependencyObject element, [In] string value);
        void SetLabeledBy([In] DependencyObject element, [In] UIElement value);
        void SetName([In] DependencyObject element, [In] string value);

        DependencyProperty AcceleratorKeyProperty { get; }

        DependencyProperty AccessKeyProperty { get; }

        DependencyProperty AutomationIdProperty { get; }

        DependencyProperty HelpTextProperty { get; }

        DependencyProperty IsRequiredForFormProperty { get; }

        DependencyProperty ItemStatusProperty { get; }

        DependencyProperty ItemTypeProperty { get; }

        DependencyProperty LabeledByProperty { get; }

        DependencyProperty NameProperty { get; }
    }
}

