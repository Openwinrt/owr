namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xa8912263, 0x2951, 0x4f58, 0xa9, 0xc5, 90, 0x13, 0x4e, 170, 0x7f, 7), ExclusiveTo(typeof(Control)), Version(0x6020000)]
    internal interface IControl
    {
        event DependencyPropertyChangedEventHandler IsEnabledChanged;

        bool ApplyTemplate();
        bool Focus([In] Windows.UI.Xaml.FocusState value);

        Brush Background { get; [param: In] set; }

        Brush BorderBrush { get; [param: In] set; }

        Thickness BorderThickness { get; [param: In] set; }

        int CharacterSpacing { get; [param: In] set; }

        Windows.UI.Xaml.FocusState FocusState { get; }

        Windows.UI.Xaml.Media.FontFamily FontFamily { get; [param: In] set; }

        double FontSize { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Windows.UI.Text.FontWeight FontWeight { get; [param: In] set; }

        Brush Foreground { get; [param: In] set; }

        HorizontalAlignment HorizontalContentAlignment { get; [param: In] set; }

        bool IsEnabled { get; [param: In] set; }

        bool IsTabStop { get; [param: In] set; }

        Thickness Padding { get; [param: In] set; }

        int TabIndex { get; [param: In] set; }

        KeyboardNavigationMode TabNavigation { get; [param: In] set; }

        ControlTemplate Template { get; [param: In] set; }

        VerticalAlignment VerticalContentAlignment { get; [param: In] set; }
    }
}

