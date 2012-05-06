namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x351b86bd, 0x43b3, 0x482b, 0x85, 0xdb, 0x35, 0xd8, 0x7b, 0x51, 0x7a, 0xd9), ExclusiveTo(typeof(WebUIApplication)), Version(0x6020000)]
    internal interface IWebUIActivationStatics
    {
        event ActivatedEventHandler Activated;

        event ResumingEventHandler Resuming;

        event SuspendingEventHandler Suspending;
    }
}

