namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DiscreteDoubleKeyFrame : DoubleKeyFrame, IDiscreteDoubleKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DiscreteDoubleKeyFrame();
    }
}

