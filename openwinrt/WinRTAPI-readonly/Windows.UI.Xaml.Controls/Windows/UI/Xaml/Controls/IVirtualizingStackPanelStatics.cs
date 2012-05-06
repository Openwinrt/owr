namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x8314e778, 0x91d3, 0x4d56, 0xac, 9, 0x22, 0x3a, 220, 210, 0xbd, 0x3f), ExclusiveTo(typeof(VirtualizingStackPanel))]
    internal interface IVirtualizingStackPanelStatics
    {
        bool GetIsVirtualizing([In] DependencyObject o);
        VirtualizationMode GetVirtualizationMode([In] DependencyObject element);
        void SetVirtualizationMode([In] DependencyObject element, [In] VirtualizationMode value);

        DependencyProperty AreScrollSnapPointsRegularProperty { get; }

        DependencyProperty IsVirtualizingProperty { get; }

        DependencyProperty OrientationProperty { get; }

        DependencyProperty VirtualizationModeProperty { get; }
    }
}

