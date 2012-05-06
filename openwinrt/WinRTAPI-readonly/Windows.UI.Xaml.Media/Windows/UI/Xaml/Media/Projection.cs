namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IProjectionFactory), CompositionType.Protected, 0x6020000)]
    public class Projection : DependencyObject, IProjection
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected Projection();
    }
}

