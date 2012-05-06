namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Grid)), Version(0x6020000), WebHostHidden, Guid(0xfd104460, 0x2e15, 0x4ba3, 0x8b, 0x8f, 250, 0x69, 0x3a, 0x41, 0x61, 0xe9)]
    internal interface IGrid
    {
        ColumnDefinitionCollection ColumnDefinitions { get; }

        RowDefinitionCollection RowDefinitions { get; }
    }
}

