namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class CubicEase : EasingFunctionBase, ICubicEase
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CubicEase();
    }
}

