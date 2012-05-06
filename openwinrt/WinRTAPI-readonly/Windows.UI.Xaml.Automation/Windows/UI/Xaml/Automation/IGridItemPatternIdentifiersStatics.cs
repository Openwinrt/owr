namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(GridItemPatternIdentifiers)), WebHostHidden, Guid(0x217d2402, 0x5e46, 0x4d61, 0x87, 0x94, 0xb8, 0xee, 0x8e, 0x77, 0x47, 20)]
    internal interface IGridItemPatternIdentifiersStatics
    {
        AutomationProperty ColumnProperty { get; }

        AutomationProperty ColumnSpanProperty { get; }

        AutomationProperty ContainingGridProperty { get; }

        AutomationProperty RowProperty { get; }

        AutomationProperty RowSpanProperty { get; }
    }
}

