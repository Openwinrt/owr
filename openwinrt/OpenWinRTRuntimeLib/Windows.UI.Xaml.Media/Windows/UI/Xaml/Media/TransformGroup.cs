namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [WebHostHidden, ContentProperty(Name="Children"), Static(typeof(ITransformGroupStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000)]
    public sealed class TransformGroup : Transform, ITransformGroup
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TransformGroup();

        public TransformCollection Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ChildrenProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Matrix Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransformCollection Windows.UI.Xaml.Media.ITransformGroup.Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Matrix Windows.UI.Xaml.Media.ITransformGroup.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

