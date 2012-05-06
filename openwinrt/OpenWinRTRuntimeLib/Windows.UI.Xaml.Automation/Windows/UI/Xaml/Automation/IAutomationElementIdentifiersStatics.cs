namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Guid(0x4549399f, 0x8340, 0x4d67, 0xb9, 0xbf, 140, 0x2a, 0xc6, 160, 0x77, 0x3a), ExclusiveTo(typeof(AutomationElementIdentifiers)), WebHostHidden, Version(0x6020000)]
    internal interface IAutomationElementIdentifiersStatics
    {
        AutomationProperty AcceleratorKeyProperty { get; }

        AutomationProperty AccessKeyProperty { get; }

        AutomationProperty AutomationIdProperty { get; }

        AutomationProperty BoundingRectangleProperty { get; }

        AutomationProperty ClassNameProperty { get; }

        AutomationProperty ClickablePointProperty { get; }

        AutomationProperty ControlTypeProperty { get; }

        AutomationProperty HasKeyboardFocusProperty { get; }

        AutomationProperty HelpTextProperty { get; }

        AutomationProperty IsContentElementProperty { get; }

        AutomationProperty IsControlElementProperty { get; }

        AutomationProperty IsEnabledProperty { get; }

        AutomationProperty IsKeyboardFocusableProperty { get; }

        AutomationProperty IsOffscreenProperty { get; }

        AutomationProperty IsPasswordProperty { get; }

        AutomationProperty IsRequiredForFormProperty { get; }

        AutomationProperty ItemStatusProperty { get; }

        AutomationProperty ItemTypeProperty { get; }

        AutomationProperty LabeledByProperty { get; }

        AutomationProperty LocalizedControlTypeProperty { get; }

        AutomationProperty NameProperty { get; }

        AutomationProperty OrientationProperty { get; }
    }
}

