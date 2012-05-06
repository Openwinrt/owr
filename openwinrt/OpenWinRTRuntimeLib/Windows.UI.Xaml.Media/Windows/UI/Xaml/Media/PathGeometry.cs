namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Threading(ThreadingModel.Both), WebHostHidden, ContentProperty(Name="Figures"), Version(0x6020000), Activatable(0x6020000), Static(typeof(IPathGeometryStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PathGeometry : Geometry, IPathGeometry
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PathGeometry();

        public PathFigureCollection Figures { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FiguresProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FillRule FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillRuleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PathFigureCollection Windows.UI.Xaml.Media.IPathGeometry.Figures { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.FillRule Windows.UI.Xaml.Media.IPathGeometry.FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

