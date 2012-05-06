namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0x331d8f00, 0xc5f9, 0x46a5, 0xb6, 200, 0xed, 0xe5, 0x39, 0x30, 0x45, 0x67), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ToggleSwitch))]
    internal interface IToggleSwitch
    {
        event RoutedEventHandler Toggled;

        object Header { get; [param: In] set; }

        DataTemplate HeaderTemplate { get; [param: In] set; }

        bool IsOn { get; [param: In] set; }

        object OffContent { get; [param: In] set; }

        DataTemplate OffContentTemplate { get; [param: In] set; }

        object OnContent { get; [param: In] set; }

        DataTemplate OnContentTemplate { get; [param: In] set; }

        ToggleSwitchTemplateSettings TemplateSettings { get; }
    }
}

