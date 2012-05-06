namespace Windows.UI.Core
{
    using Windows.Foundation.Metadata;
    using Windows.System;

    [WebHostHidden, ExclusiveTo(typeof(AcceleratorKeyEventArgs)), Version(0x6020000), Guid(0xff1c4c4a, 0x9287, 0x470b, 0x83, 110, 0x90, 0x86, 0xe3, 0x12, 0x6a, 0xde)]
    internal interface IAcceleratorKeyEventArgs : ICoreWindowEventArgs
    {
        CoreAcceleratorKeyEventType EventType { get; }

        CorePhysicalKeyStatus KeyStatus { get; }

        Windows.System.VirtualKey VirtualKey { get; }
    }
}

