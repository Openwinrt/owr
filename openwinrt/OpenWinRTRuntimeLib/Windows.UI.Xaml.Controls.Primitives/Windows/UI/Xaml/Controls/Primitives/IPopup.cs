namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media.Animation;

    [Version(0x6020000), ExclusiveTo(typeof(Popup)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x62418240, 0xe6d3, 0x4705, 0xa1, 220, 0x39, 0x15, 100, 0x56, 0xee, 0x29)]
    internal interface IPopup
    {
        event Windows.Foundation.EventHandler<object> Closed;

        event Windows.Foundation.EventHandler<object> Opened;

        UIElement Child { get; [param: In] set; }

        TransitionCollection ChildTransitions { get; [param: In] set; }

        double HorizontalOffset { get; [param: In] set; }

        bool IsLightDismissEnabled { get; [param: In] set; }

        bool IsOpen { get; [param: In] set; }

        double VerticalOffset { get; [param: In] set; }
    }
}

