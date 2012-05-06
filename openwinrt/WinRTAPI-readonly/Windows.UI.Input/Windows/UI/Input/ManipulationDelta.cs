namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct ManipulationDelta
    {
        public Point Translation;
        public float Scale;
        public float Rotation;
        public float Expansion;
    }
}

