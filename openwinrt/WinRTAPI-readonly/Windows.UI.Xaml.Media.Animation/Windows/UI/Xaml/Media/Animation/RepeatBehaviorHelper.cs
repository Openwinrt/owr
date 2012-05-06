namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IRepeatBehaviorHelperStatics), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class RepeatBehaviorHelper : IRepeatBehaviorHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Equals([In] RepeatBehavior target, [In] RepeatBehavior value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static RepeatBehavior FromCount([In] double count);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static RepeatBehavior FromDuration([In] Windows.Foundation.TimeSpan duration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHasCount([In] RepeatBehavior target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHasDuration([In] RepeatBehavior target);

        public static RepeatBehavior Forever { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

