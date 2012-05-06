namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), WebHostHidden, Version(0x6020000)]
    public struct CorePhysicalKeyStatus
    {
        public uint RepeatCount;
        public uint ScanCode;
        public bool IsExtendedKey;
        public bool IsMenuKeyDown;
        public bool WasKeyDown;
        public bool IsKeyReleased;
    }
}

