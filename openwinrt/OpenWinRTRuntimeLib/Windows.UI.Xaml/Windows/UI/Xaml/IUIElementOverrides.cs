namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Peers;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x608d2f1d, 0x7858, 0x4aeb, 0x89, 0xe4, 0xb5, 0x4e, 0x2c, 0x7e, 0xd3, 0xd3), ExclusiveTo(typeof(UIElement))]
    internal interface IUIElementOverrides
    {
        IIterable<IIterable<Point>> FindSubElementsForTouchTargeting([In] Point point, [In] Rect boundingRect);
        AutomationPeer OnCreateAutomationPeer();
        void OnDisconnectVisualChildren();
    }
}

