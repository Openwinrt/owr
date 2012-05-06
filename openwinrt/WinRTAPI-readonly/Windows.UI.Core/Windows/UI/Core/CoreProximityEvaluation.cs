namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), WebHostHidden, Version(0x6020000)]
    public struct CoreProximityEvaluation
    {
        public int Score;
        public Point AdjustedPoint;
    }
}

