namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MatrixTransform)), Windows.Foundation.Metadata.Guid(0xedfdd551, 0x5fed, 0x45fc, 0xae, 0x62, 0x92, 0xa4, 0xb6, 0xcf, 0x97, 7), Version(0x6020000), WebHostHidden]
    internal interface IMatrixTransform
    {
        Windows.UI.Xaml.Media.Matrix Matrix { get; [param: In] set; }
    }
}

