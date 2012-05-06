namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(SelectionItemPatternIdentifiers)), Version(0x6020000), Guid(0xa918d163, 0x487e, 0x4e3e, 0x9f, 0x86, 0x7b, 0x44, 0xac, 190, 0x27, 0xce)]
    internal interface ISelectionItemPatternIdentifiersStatics
    {
        AutomationProperty IsSelectedProperty { get; }

        AutomationProperty SelectionContainerProperty { get; }
    }
}

