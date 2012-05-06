namespace Windows.UI.Xaml.Automation
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x4bf8e0a1, 0xfb7f, 0x4fa4, 0x83, 0xb3, 0xcf, 0xae, 0xb1, 3, 0xa6, 0x85), ExclusiveTo(typeof(ScrollPatternIdentifiers)), WebHostHidden, Version(0x6020000)]
    internal interface IScrollPatternIdentifiersStatics
    {
        AutomationProperty HorizontallyScrollableProperty { get; }

        AutomationProperty HorizontalScrollPercentProperty { get; }

        AutomationProperty HorizontalViewSizeProperty { get; }

        double NoScroll { get; }

        AutomationProperty VerticallyScrollableProperty { get; }

        AutomationProperty VerticalScrollPercentProperty { get; }

        AutomationProperty VerticalViewSizeProperty { get; }
    }
}

