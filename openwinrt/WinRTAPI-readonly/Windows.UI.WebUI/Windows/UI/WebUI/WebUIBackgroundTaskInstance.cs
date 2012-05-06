namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IWebUIBackgroundTaskInstanceStatics), 0x6020000), Version(0x6020000)]
    public static class WebUIBackgroundTaskInstance
    {
        public static IWebUIBackgroundTaskInstance Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

