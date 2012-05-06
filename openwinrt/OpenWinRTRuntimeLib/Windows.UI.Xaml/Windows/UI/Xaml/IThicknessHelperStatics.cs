namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xc0991a7c, 0x70c, 0x4da6, 0x87, 0x84, 1, 0xca, 0x80, 14, 0xb7, 0x3a), Version(0x6020000), ExclusiveTo(typeof(ThicknessHelper))]
    internal interface IThicknessHelperStatics
    {
        Thickness FromLengths([In] double left, [In] double top, [In] double right, [In] double bottom);
        Thickness FromUniformLength([In] double uniformLength);
    }
}

