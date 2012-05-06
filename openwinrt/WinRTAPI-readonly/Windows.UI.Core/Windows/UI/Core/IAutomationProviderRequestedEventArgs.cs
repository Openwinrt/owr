namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(AutomationProviderRequestedEventArgs)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x961ff258, 0x21bf, 0x4b42, 0xa2, 0x98, 250, 0x47, 0x9d, 0x4c, 0x52, 0xe2)]
    internal interface IAutomationProviderRequestedEventArgs : ICoreWindowEventArgs
    {
        object AutomationProvider { get; [param: In] set; }
    }
}

