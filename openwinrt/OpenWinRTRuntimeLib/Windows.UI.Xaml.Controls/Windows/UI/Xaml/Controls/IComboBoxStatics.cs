namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x3e14c9b1, 0xd15b, 0x4dc9, 0x81, 0x10, 0xcf, 0x3a, 0x11, 0x7b, 150, 0xe7), ExclusiveTo(typeof(ComboBox)), WebHostHidden, Version(0x6020000)]
    internal interface IComboBoxStatics
    {
        DependencyProperty IsDropDownOpenProperty { get; }

        DependencyProperty MaxDropDownHeightProperty { get; }
    }
}

