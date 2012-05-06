namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RepeatBehaviorHelper)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7a795033, 0x79f3, 0x4dd9, 0xb2, 0x67, 0x9c, 0xf5, 15, 0xb5, 0x1f, 0x84)]
    internal interface IRepeatBehaviorHelperStatics
    {
        bool Equals([In] RepeatBehavior target, [In] RepeatBehavior value);
        RepeatBehavior FromCount([In] double count);
        RepeatBehavior FromDuration([In] Windows.Foundation.TimeSpan duration);
        bool GetHasCount([In] RepeatBehavior target);
        bool GetHasDuration([In] RepeatBehavior target);

        RepeatBehavior Forever { get; }
    }
}

