namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(VisualStateManager)), Windows.Foundation.Metadata.Guid(0x4b3b8640, 0xb0b7, 0x404c, 0x9e, 0xf4, 0xd9, 0x49, 100, 14, 0x24, 0x5d)]
    internal interface IVisualStateManagerProtected
    {
        void RaiseCurrentStateChanged([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
        void RaiseCurrentStateChanging([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
    }
}

