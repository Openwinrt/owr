namespace Windows.UI.Core
{
    using Windows.Foundation.Metadata;
    using Windows.System;

    [Version(0x6020000), Guid(0x5ff5e930, 0x2544, 0x4a17, 0xbd, 120, 0x1f, 0x2f, 0xde, 0xbb, 0x10, 0x6b), WebHostHidden]
    public interface IKeyEventArgs : ICoreWindowEventArgs
    {
        CorePhysicalKeyStatus KeyStatus { get; }

        Windows.System.VirtualKey VirtualKey { get; }
    }
}

