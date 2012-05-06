namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ColumnDefinition)), Version(0x6020000), Guid(0x6b0d728, 0xd044, 0x40c6, 0x94, 0x2e, 0xae, 0x60, 0xea, 0xc7, 0x48, 0x51), WebHostHidden]
    internal interface IColumnDefinitionStatics
    {
        DependencyProperty MaxWidthProperty { get; }

        DependencyProperty MinWidthProperty { get; }

        DependencyProperty WidthProperty { get; }
    }
}

