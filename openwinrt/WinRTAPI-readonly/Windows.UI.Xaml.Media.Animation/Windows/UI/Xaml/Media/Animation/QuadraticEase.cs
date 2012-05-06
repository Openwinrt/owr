namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000)]
    public sealed class QuadraticEase : EasingFunctionBase, IQuadraticEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public QuadraticEase();
    }
}

