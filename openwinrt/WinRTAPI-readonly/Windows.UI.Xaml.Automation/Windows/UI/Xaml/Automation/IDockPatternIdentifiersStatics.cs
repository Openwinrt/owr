namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(DockPatternIdentifiers)), Version(0x6020000), Guid(0x2b87245c, 0xed80, 0x4fe5, 0x8e, 180, 0x70, 0x8a, 0x39, 200, 0x41, 0xe5)]
    internal interface IDockPatternIdentifiersStatics
    {
        AutomationProperty DockPositionProperty { get; }
    }
}

