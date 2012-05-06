namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xc247e8f7, 0xadcc, 0x440f, 0xb1, 0x23, 0x33, 120, 0x8a, 0x40, 0x52, 90), WebHostHidden, ExclusiveTo(typeof(ValuePatternIdentifiers))]
    internal interface IValuePatternIdentifiersStatics
    {
        AutomationProperty IsReadOnlyProperty { get; }

        AutomationProperty ValueProperty { get; }
    }
}

