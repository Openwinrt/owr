namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), Activatable(0x6020000), WebHostHidden]
    public sealed class CircleEase : EasingFunctionBase, ICircleEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CircleEase();
    }
}

