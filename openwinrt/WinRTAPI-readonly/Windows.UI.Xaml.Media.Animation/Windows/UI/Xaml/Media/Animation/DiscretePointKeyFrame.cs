namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class DiscretePointKeyFrame : PointKeyFrame, IDiscretePointKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DiscretePointKeyFrame();
    }
}

