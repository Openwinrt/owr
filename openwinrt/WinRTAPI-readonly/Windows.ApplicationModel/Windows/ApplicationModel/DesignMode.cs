namespace Windows.ApplicationModel
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IDesignModeStatics), 0x6020000)]
    public static class DesignMode
    {
        public static bool DesignModeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

