namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x638bb2db, 0x451d, 0x4661, 0xb0, 0x99, 0x41, 0x4f, 0x34, 0xff, 0xb9, 0xf1), ExclusiveTo(typeof(CoreApplicationView))]
    internal interface ICoreApplicationView
    {
        event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

        Windows.UI.Core.CoreWindow CoreWindow { get; }

        bool IsHosted { get; }

        bool IsMain { get; }
    }
}

