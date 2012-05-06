namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(EventTrigger)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xdef8f855, 0xb49, 0x4087, 0xb1, 0xa9, 0xb8, 0xb3, 0x84, 0x88, 0xf7, 0x86)]
    internal interface IEventTrigger
    {
        TriggerActionCollection Actions { get; }

        Windows.UI.Xaml.RoutedEvent RoutedEvent { get; [param: In] set; }
    }
}

