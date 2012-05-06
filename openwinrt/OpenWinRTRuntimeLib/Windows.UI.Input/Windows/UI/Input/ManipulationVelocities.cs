namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct ManipulationVelocities
    {
        public Point Linear;
        public float Angular;
        public float Expansion;
    }
}

