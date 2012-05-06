namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(PasswordBox)), Guid(0x5ee67563, 0x2d74, 0x4ace, 0xbd, 0x79, 0xfc, 0xab, 0x61, 0xa7, 0xd7, 0x7b), Version(0x6020000), WebHostHidden]
    internal interface IPasswordBoxStatics
    {
        DependencyProperty IsPasswordRevealButtonEnabledProperty { get; }

        DependencyProperty MaxLengthProperty { get; }

        DependencyProperty PasswordCharProperty { get; }

        DependencyProperty PasswordProperty { get; }
    }
}

