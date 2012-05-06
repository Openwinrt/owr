namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IWebUIActivationStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public static class WebUIApplication
    {
        public static  event ActivatedEventHandler Activated;

        public static  event ResumingEventHandler Resuming;

        public static  event SuspendingEventHandler Suspending;
    }
}

