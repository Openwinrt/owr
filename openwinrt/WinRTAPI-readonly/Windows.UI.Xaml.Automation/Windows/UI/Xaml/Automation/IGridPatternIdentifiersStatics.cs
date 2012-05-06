namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(GridPatternIdentifiers)), Guid(0x7bc452f3, 0xa181, 0x4137, 0x8d, 0xe9, 0x1f, 0x9b, 0x1a, 0x83, 0x20, 0xed)]
    internal interface IGridPatternIdentifiersStatics
    {
        AutomationProperty ColumnCountProperty { get; }

        AutomationProperty RowCountProperty { get; }
    }
}

