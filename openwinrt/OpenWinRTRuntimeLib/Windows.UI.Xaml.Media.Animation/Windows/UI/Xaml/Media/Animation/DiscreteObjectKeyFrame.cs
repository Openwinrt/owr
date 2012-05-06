namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Activatable(0x6020000)]
    public sealed class DiscreteObjectKeyFrame : ObjectKeyFrame, IDiscreteObjectKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DiscreteObjectKeyFrame();
    }
}

