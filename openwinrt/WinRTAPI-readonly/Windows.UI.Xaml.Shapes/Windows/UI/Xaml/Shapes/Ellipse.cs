namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class Ellipse : Shape, IEllipse
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Ellipse();
    }
}

