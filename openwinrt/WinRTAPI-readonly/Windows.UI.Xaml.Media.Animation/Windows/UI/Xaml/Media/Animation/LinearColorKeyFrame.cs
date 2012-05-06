namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class LinearColorKeyFrame : ColorKeyFrame, ILinearColorKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LinearColorKeyFrame();
    }
}

