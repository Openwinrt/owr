namespace Windows.System.Display
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DisplayRequest : IDisplayRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DisplayRequest();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RequestActive();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RequestRelease();
    }
}

