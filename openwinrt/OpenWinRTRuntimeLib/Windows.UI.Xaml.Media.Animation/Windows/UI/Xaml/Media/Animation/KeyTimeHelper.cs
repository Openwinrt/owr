namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IKeyTimeHelperStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class KeyTimeHelper : IKeyTimeHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static KeyTime FromTimeSpan([In] Windows.Foundation.TimeSpan timeSpan);
    }
}

