namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xb9a8d05c, 0xac97, 0x47f1, 0xa5, 0xf4, 0x3f, 0x9f, 0x4d, 0x4b, 0x11, 0x6c), Version(0x6020000), ExclusiveTo(typeof(ComboBox))]
    internal interface IComboBox
    {
        event Windows.Foundation.EventHandler<object> DropDownClosed;

        event Windows.Foundation.EventHandler<object> DropDownOpened;

        bool IsDropDownOpen { get; [param: In] set; }

        bool IsEditable { get; }

        bool IsSelectionBoxHighlighted { get; }

        double MaxDropDownHeight { get; [param: In] set; }

        object SelectionBoxItem { get; }

        DataTemplate SelectionBoxItemTemplate { get; }

        ComboBoxTemplateSettings TemplateSettings { get; }
    }
}

