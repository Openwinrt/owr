namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Static(typeof(ICameraOptionsUIStatics), 0x6020000), MarshalingBehavior(MarshalingType.Standard), Version(0x6020000)]
    public static class CameraOptionsUI
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Show([In] MediaCapture mediaCapture);
    }
}

