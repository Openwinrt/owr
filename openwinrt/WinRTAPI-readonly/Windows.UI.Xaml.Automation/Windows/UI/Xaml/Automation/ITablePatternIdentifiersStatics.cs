namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TablePatternIdentifiers)), Guid(0x75073d25, 0x32c9, 0x4903, 0xae, 0xcf, 220, 0x35, 4, 0xcb, 210, 0x44), Version(0x6020000), WebHostHidden]
    internal interface ITablePatternIdentifiersStatics
    {
        AutomationProperty ColumnHeadersProperty { get; }

        AutomationProperty RowHeadersProperty { get; }

        AutomationProperty RowOrColumnMajorProperty { get; }
    }
}

