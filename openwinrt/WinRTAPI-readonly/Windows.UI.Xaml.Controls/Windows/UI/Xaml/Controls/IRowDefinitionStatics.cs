namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0x5adf3fe5, 0x2056, 0x4724, 0x94, 0xd6, 0xe4, 0x81, 0x2b, 2, 0x2e, 200), ExclusiveTo(typeof(RowDefinition)), WebHostHidden]
    internal interface IRowDefinitionStatics
    {
        DependencyProperty HeightProperty { get; }

        DependencyProperty MaxHeightProperty { get; }

        DependencyProperty MinHeightProperty { get; }
    }
}

