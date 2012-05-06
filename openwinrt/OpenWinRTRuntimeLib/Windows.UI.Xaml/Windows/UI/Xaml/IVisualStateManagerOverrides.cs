namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), ExclusiveTo(typeof(VisualStateManager)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4a66910e, 0x7979, 0x43c8, 0x8f, 0xf4, 0xec, 0x61, 0x22, 0x75, 0, 6)]
    internal interface IVisualStateManagerOverrides
    {
        bool GoToStateCore([In] Control control, [In] FrameworkElement templateRoot, [In] string stateName, [In] VisualStateGroup group, [In] VisualState state, [In] bool useTransitions);
    }
}

