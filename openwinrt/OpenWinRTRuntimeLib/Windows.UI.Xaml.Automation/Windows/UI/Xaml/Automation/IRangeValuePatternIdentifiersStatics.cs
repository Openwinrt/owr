namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Guid(0xce23450f, 0x1c27, 0x457f, 0xb8, 0x15, 0x7a, 0x5e, 70, 0x86, 0x3d, 0xbb), ExclusiveTo(typeof(RangeValuePatternIdentifiers)), WebHostHidden, Version(0x6020000)]
    internal interface IRangeValuePatternIdentifiersStatics
    {
        AutomationProperty IsReadOnlyProperty { get; }

        AutomationProperty LargeChangeProperty { get; }

        AutomationProperty MaximumProperty { get; }

        AutomationProperty MinimumProperty { get; }

        AutomationProperty SmallChangeProperty { get; }

        AutomationProperty ValueProperty { get; }
    }
}

