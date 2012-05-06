namespace Windows.System.RemoteDesktop
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IInteractiveSessionStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public static class InteractiveSession
    {
        public static bool IsRemote { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

