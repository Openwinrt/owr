namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IDurationHelperStatics), 0x6020000), WebHostHidden]
    public sealed class DurationHelper : IDurationHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Duration Add([In] Duration target, [In] Duration duration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int Compare([In] Duration duration1, [In] Duration duration2);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool Equals([In] Duration target, [In] Duration value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Duration FromTimeSpan([In] Windows.Foundation.TimeSpan timeSpan);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHasTimeSpan([In] Duration target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Duration Subtract([In] Duration target, [In] Duration duration);

        public static Duration Automatic { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Duration Forever { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

