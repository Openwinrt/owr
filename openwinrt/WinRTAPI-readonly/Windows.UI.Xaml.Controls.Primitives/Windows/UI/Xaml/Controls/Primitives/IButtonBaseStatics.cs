namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(ButtonBase)), Guid(0x67ef17e1, 0xfe37, 0x474f, 0x9e, 0x97, 0x3b, 0x5e, 11, 0x30, 0xf2, 0xdf), WebHostHidden]
    internal interface IButtonBaseStatics
    {
        DependencyProperty ClickModeProperty { get; }

        DependencyProperty CommandParameterProperty { get; }

        DependencyProperty CommandProperty { get; }

        DependencyProperty IsPointerOverProperty { get; }

        DependencyProperty IsPressedProperty { get; }
    }
}

