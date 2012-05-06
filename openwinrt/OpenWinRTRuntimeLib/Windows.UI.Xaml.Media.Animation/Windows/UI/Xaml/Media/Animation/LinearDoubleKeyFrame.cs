namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Activatable(0x6020000)]
    public sealed class LinearDoubleKeyFrame : DoubleKeyFrame, ILinearDoubleKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LinearDoubleKeyFrame();
    }
}

