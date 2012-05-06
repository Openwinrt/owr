namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(MatrixHelper)), Windows.Foundation.Metadata.Guid(0xc18606a6, 0x39f4, 0x4b8a, 0x84, 3, 40, 0xe5, 0xe5, 240, 0x33, 180)]
    internal interface IMatrixHelperStatics
    {
        Matrix FromElements([In] double m11, [In] double m12, [In] double m21, [In] double m22, [In] double offsetX, [In] double offsetY);
        bool GetIsIdentity([In] Matrix target);
        Point Transform([In] Matrix target, [In] Point point);

        Matrix Identity { get; }
    }
}

