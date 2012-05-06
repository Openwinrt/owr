namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(ToolTip)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x7de5d75f, 0x4415, 0x429f, 0xb5, 0x23, 0x69, 0x9b, 0xdb, 140, 0x30, 0xdb)]
    internal interface IToolTip
    {
        event RoutedEventHandler Closed;

        event RoutedEventHandler Opened;

        double HorizontalOffset { get; [param: In] set; }

        bool IsOpen { get; [param: In] set; }

        PlacementMode Placement { get; [param: In] set; }

        UIElement PlacementTarget { get; [param: In] set; }

        ToolTipTemplateSettings TemplateSettings { get; }

        double VerticalOffset { get; [param: In] set; }
    }
}

