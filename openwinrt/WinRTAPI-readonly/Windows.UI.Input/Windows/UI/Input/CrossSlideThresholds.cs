namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct CrossSlideThresholds
    {
        public float SelectionStart;
        public float SpeedBumpStart;
        public float SpeedBumpEnd;
        public float RearrangeStart;
    }
}

