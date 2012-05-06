namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IGeometryGroupStatics), 0x6020000), WebHostHidden, ContentProperty(Name="Children"), Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class GeometryGroup : Geometry, IGeometryGroup
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GeometryGroup();

        public GeometryCollection Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ChildrenProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.FillRule FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FillRuleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeometryCollection Windows.UI.Xaml.Media.IGeometryGroup.Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.FillRule Windows.UI.Xaml.Media.IGeometryGroup.FillRule { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

