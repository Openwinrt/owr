namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x27717c9b, 0x2c35, 0x42bb, 0xab, 0x70, 12, 0x1b, 0xcc, 0x5b, 0xae, 0x16), Version(0x6020000), ExclusiveTo(typeof(ApplicationView))]
    internal interface IApplicationView
    {
        event TypedEventHandler<ApplicationView, ApplicationViewStateChangedEventArgs> ViewStateChanged;
    }
}

