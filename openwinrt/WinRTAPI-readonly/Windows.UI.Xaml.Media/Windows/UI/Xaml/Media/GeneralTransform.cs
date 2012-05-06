namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(IGeneralTransformFactory), CompositionType.Protected, 0x6020000), WebHostHidden]
    public class GeneralTransform : DependencyObject, IGeneralTransform, IGeneralTransformOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected GeneralTransform();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect TransformBounds([In] Rect rect);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Rect TransformBoundsCore([In] Rect rect);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Point TransformPoint([In] Point point);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool TryTransform([In] Point inPoint, out Point outPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool TryTransformCore([In] Point inPoint, out Point outPoint);

        public GeneralTransform Inverse { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        protected virtual GeneralTransform InverseCore { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeneralTransform Windows.UI.Xaml.Media.IGeneralTransform.Inverse { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        protected virtual GeneralTransform Windows.UI.Xaml.Media.IGeneralTransformOverrides.InverseCore { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

