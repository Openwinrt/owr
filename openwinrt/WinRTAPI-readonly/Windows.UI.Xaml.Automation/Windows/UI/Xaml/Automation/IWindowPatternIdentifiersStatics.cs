namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Guid(0x7d0ad06, 0x6302, 0x4d29, 0x87, 0x8b, 0x19, 0xda, 3, 0xfc, 0x22, 0x8d), ExclusiveTo(typeof(WindowPatternIdentifiers))]
    internal interface IWindowPatternIdentifiersStatics
    {
        AutomationProperty CanMaximizeProperty { get; }

        AutomationProperty CanMinimizeProperty { get; }

        AutomationProperty IsModalProperty { get; }

        AutomationProperty IsTopmostProperty { get; }

        AutomationProperty WindowInteractionStateProperty { get; }

        AutomationProperty WindowVisualStateProperty { get; }
    }
}

