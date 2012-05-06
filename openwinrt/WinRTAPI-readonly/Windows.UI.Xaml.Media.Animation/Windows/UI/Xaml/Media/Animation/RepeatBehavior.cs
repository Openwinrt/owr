namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000), WebHostHidden]
    public struct RepeatBehavior
    {
        public double Count;
        public Windows.Foundation.TimeSpan Duration;
        public RepeatBehaviorType Type;
    }
}

