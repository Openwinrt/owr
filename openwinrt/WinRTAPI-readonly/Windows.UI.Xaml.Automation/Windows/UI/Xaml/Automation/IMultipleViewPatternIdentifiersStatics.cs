namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MultipleViewPatternIdentifiers)), WebHostHidden, Guid(0xa9cfa66f, 0x6b84, 0x4d71, 0x9e, 0x48, 0xd7, 100, 0xd3, 0xbc, 0xda, 0x8e)]
    internal interface IMultipleViewPatternIdentifiersStatics
    {
        AutomationProperty CurrentViewProperty { get; }

        AutomationProperty SupportedViewsProperty { get; }
    }
}

