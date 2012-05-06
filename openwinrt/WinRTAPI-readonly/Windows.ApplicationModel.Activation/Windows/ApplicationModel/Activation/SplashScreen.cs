namespace Windows.ApplicationModel.Activation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SplashScreen : ISplashScreen
    {
        public event TypedEventHandler<SplashScreen, object> Dismissed;

        public event TypedEventHandler<SplashScreen, object> Windows.ApplicationModel.Activation.ISplashScreen.Dismissed;

        public Rect ImageLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.ApplicationModel.Activation.ISplashScreen.ImageLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

