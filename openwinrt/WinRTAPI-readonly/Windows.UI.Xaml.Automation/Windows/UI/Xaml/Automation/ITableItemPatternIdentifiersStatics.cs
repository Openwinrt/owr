namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TableItemPatternIdentifiers)), Version(0x6020000), WebHostHidden, Guid(0x24c4b923, 0xe9a2, 0x4de9, 0xb2, 0xa4, 0xa8, 0xb2, 0x2d, 11, 0xe3, 0x62)]
    internal interface ITableItemPatternIdentifiersStatics
    {
        AutomationProperty ColumnHeaderItemsProperty { get; }

        AutomationProperty RowHeaderItemsProperty { get; }
    }
}

