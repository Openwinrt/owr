namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), Static(typeof(IPathStatics), 0x6020000), WebHostHidden, Composable(typeof(IPathFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class Path : Shape, IPath
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Path();

        public Geometry Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DataProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Geometry Windows.UI.Xaml.Shapes.IPath.Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

