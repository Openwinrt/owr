namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [ExclusiveTo(typeof(VisualStateManager)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x1d0e9e0, 0xd713, 0x414e, 0xa7, 0x4e, 230, 0x3e, 0xc7, 0xac, 140, 0x3d)]
    internal interface IVisualStateManagerStatics
    {
        VisualStateManager GetCustomVisualStateManager([In] FrameworkElement obj);
        IVector<VisualStateGroup> GetVisualStateGroups([In] FrameworkElement obj);
        bool GoToState([In] Control control, [In] string stateName, [In] bool useTransitions);
        void SetCustomVisualStateManager([In] FrameworkElement obj, [In] VisualStateManager value);

        DependencyProperty CustomVisualStateManagerProperty { get; }
    }
}

