namespace Windows.ApplicationModel.Activation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SplashScreen)), Windows.Foundation.Metadata.Guid(0xca4d975c, 0xd4d6, 0x43f0, 0x97, 0xc0, 8, 0x33, 0xc6, 0x39, 0x1c, 0x24)]
    internal interface ISplashScreen
    {
        event TypedEventHandler<SplashScreen, object> Dismissed;

        Rect ImageLocation { get; }
    }
}

