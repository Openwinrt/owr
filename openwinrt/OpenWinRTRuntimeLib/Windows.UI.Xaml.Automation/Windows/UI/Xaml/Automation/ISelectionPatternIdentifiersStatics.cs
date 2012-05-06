namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(SelectionPatternIdentifiers)), Guid(0x93035b4c, 0x6b50, 0x40a1, 0xb2, 0x3f, 0x5c, 120, 0xdd, 0xbd, 0x47, 0x9a)]
    internal interface ISelectionPatternIdentifiersStatics
    {
        AutomationProperty CanSelectMultipleProperty { get; }

        AutomationProperty IsSelectionRequiredProperty { get; }

        AutomationProperty SelectionProperty { get; }
    }
}

