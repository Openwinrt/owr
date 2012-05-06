namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x83285c4e, 0x17f6, 0x4aa3, 0xb6, 0x1b, 0xe8, 0x7c, 0x71, 0x86, 4, 0xea), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ComboBoxTemplateSettings))]
    internal interface IComboBoxTemplateSettings
    {
        double DropDownClosedHeight { get; }

        double DropDownOffset { get; }

        double DropDownOpenedHeight { get; }

        AnimationDirection SelectedItemDirection { get; }
    }
}

