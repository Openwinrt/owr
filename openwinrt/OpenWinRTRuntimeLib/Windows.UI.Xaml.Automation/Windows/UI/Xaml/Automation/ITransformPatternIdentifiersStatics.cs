namespace Windows.UI.Xaml.Automation
{
    using Windows.Foundation.Metadata;

    [Guid(0x4570edab, 0xd705, 0x40c4, 0xa1, 220, 0xe9, 0xac, 0xfc, 0xef, 0x85, 0xf6), ExclusiveTo(typeof(TransformPatternIdentifiers)), Version(0x6020000), WebHostHidden]
    internal interface ITransformPatternIdentifiersStatics
    {
        AutomationProperty CanMoveProperty { get; }

        AutomationProperty CanResizeProperty { get; }

        AutomationProperty CanRotateProperty { get; }
    }
}

