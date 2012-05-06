namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x86e649f8, 0xe245, 0x48aa, 0xa8, 200, 0xd1, 7, 0x3e, 0xd7, 0x63, 0x19), Version(0x6020000), ExclusiveTo(typeof(ToolTipService))]
    internal interface IToolTipServiceStatics
    {
        PlacementMode GetPlacement([In] DependencyObject element);
        UIElement GetPlacementTarget([In] DependencyObject element);
        object GetToolTip([In] DependencyObject element);
        void SetPlacement([In] DependencyObject element, [In] PlacementMode value);
        void SetPlacementTarget([In] DependencyObject element, [In] UIElement value);
        void SetToolTip([In] DependencyObject element, [In] object value);

        DependencyProperty PlacementProperty { get; }

        DependencyProperty PlacementTargetProperty { get; }

        DependencyProperty ToolTipProperty { get; }
    }
}

