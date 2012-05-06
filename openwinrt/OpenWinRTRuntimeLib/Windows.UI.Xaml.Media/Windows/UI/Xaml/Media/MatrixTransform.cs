namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Static(typeof(IMatrixTransformStatics), 0x6020000), Version(0x6020000)]
    public sealed class MatrixTransform : Transform, IMatrixTransform
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MatrixTransform();

        public Windows.UI.Xaml.Media.Matrix Matrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MatrixProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Matrix Windows.UI.Xaml.Media.IMatrixTransform.Matrix { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

