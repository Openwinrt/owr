namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Static(typeof(IPointHelperStatics), 0x6020000), Version(0x6020000)]
    public sealed class PointHelper : IPointHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Point FromCoordinates([In] float x, [In] float y);
    }
}

